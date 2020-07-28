using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProgrammaticFiltering.Data;
using ProgrammaticFiltering.Models;
using ProgrammaticFiltering.Pages;

namespace ProgrammaticFiltering
{
    public class OutboundReportModel : DI_BasePageModel
    {
        public string url;
        public string embedToken;
        private UserManager<ApplicationUser> _userManager;
        private ApplicationUserDataAccessLayer _applicationUserDataAccessLayer;

        public OutboundReportModel(
            ApplicationDbContext context,
            IAuthorizationService authorizationService,
            UserManager<ApplicationUser> userManager,
            IProgrammaticFilteringService programmaticFilteringService,
            ApplicationUserDataAccessLayer applicationUserDataAccessLayer)
            : base(context, authorizationService, userManager, programmaticFilteringService)
        {
            _userManager = userManager;
            _applicationUserDataAccessLayer = applicationUserDataAccessLayer;
        }

        public async Task OnGetAsync()
        {
            var qTimeFilter = HttpContext.Request.Query["tf"].ToString();
            var qAnyDayFilter = HttpContext.Request.Query["ad"].ToString();
            var qFromDateFilter = HttpContext.Request.Query["sfd"].ToString();
            var qToDateFilter = HttpContext.Request.Query["std"].ToString();
            var qCampaignFilter = HttpContext.Request.Query["cp"].ToString();
            var qCallTypeFilter = HttpContext.Request.Query["ct"].ToString();
            var qSkillFilter = HttpContext.Request.Query["s"].ToString();
            var qAgentGroupFilter = HttpContext.Request.Query["ag"].ToString();
            var qAgentFilter = HttpContext.Request.Query["a"].ToString();
            //var qCampaignTypeFilter = HttpContext.Request.Query["cpt"].ToString();

            var timeFrameFilter = "";
            var anyDayFilter = "";
            var dateRangeFilter = "";
            var campaignFilter = "";
            var callTypeFilter = "";
            var skillFilter = "";
            var agentGroupFilter = "";
            var agentFilter = "";
            //var campaignTypeFilter = "";
            StringBuilder sbFilters = new StringBuilder();
            StringBuilder sbSplitFilter = new StringBuilder();
            var filters = "";

            //var username = UserManager.GetUserName(User);
            //ProgrammaticFilter programmaticFilter = ProgrammaticFilteringService.getProgrammaticFilter(username);
            //programmaticFilter.EmbedId = "rkZ0W";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var clientDashboard = _applicationUserDataAccessLayer.GetClientDashboardByClientIdAndDashboardType(user.ClientId, "outbound");

            url = Constants.EmbedUrl + clientDashboard.DashboardEmbedId;
            var domoHttpClient = new DomoHttpClient();

            if (qTimeFilter != "")
            {
                DateTime date = DateTime.UtcNow.Date;

                if (qTimeFilter == "today")
                    timeFrameFilter = "[{\"column\":\"TimeStamp\",\"operator\": \"EQUALS\",\"values\": [\"" + date.ToString("yyyy-MM-dd") + "\"]}";
                else if (qTimeFilter == "yesterday")
                    timeFrameFilter = "[{\"column\":\"TimeStamp\",\"operator\": \"EQUALS\",\"values\": [\"" + date.AddDays(-1).Date.ToString("yyyy-MM-dd") + "\"]}";
                else if (qTimeFilter == "last7days")
                    timeFrameFilter = "[{\"column\":\"TimeStamp\",\"operator\":\"GREAT_THAN_EQUALS_TO\",\"values\":[\"" + date.AddDays(-7).ToString("yyyy-MM-dd") + "\"]},{\"column\":\"TimeStamp\",\"operator\":\"LESS_THAN_EQUALS_TO\",\"values\":[\"" + date.ToString("yyyy-MM-dd") + "\"]}";
                else if (qTimeFilter == "last30days")
                    timeFrameFilter = "[{\"column\":\"TimeStamp\",\"operator\":\"GREAT_THAN_EQUALS_TO\",\"values\":[\"" + date.AddDays(-30).ToString("yyyy-MM-dd") + "\"]},{\"column\":\"TimeStamp\",\"operator\":\"LESS_THAN_EQUALS_TO\",\"values\":[\"" + date.ToString("yyyy-MM-dd") + "\"]}";
                else if (qTimeFilter == "week")
                    timeFrameFilter = "[{\"column\":\"TimeStamp\",\"operator\":\"GREAT_THAN_EQUALS_TO\",\"values\":[\"" + date.AddDays(-1 * (int)(DateTime.Today.DayOfWeek)).ToString("yyyy-MM-dd") + "\"]},{\"column\":\"TimeStamp\",\"operator\":\"LESS_THAN_EQUALS_TO\",\"values\":[\"" + date.ToString("yyyy-MM-dd") + "\"]}";
                else if (qTimeFilter == "month")
                {
                    DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
                    timeFrameFilter = "[{\"column\":\"TimeStamp\",\"operator\":\"GREAT_THAN_EQUALS_TO\",\"values\":[\"" + firstDayOfMonth.ToString("yyyy-MM-dd") + "\"]},{\"column\":\"TimeStamp\",\"operator\":\"LESS_THAN_EQUALS_TO\",\"values\":[\"" + firstDayOfMonth.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd") + "\"]}";
                }
                else if (qTimeFilter == "previousweek")
                    timeFrameFilter = "[{\"column\":\"TimeStamp\",\"operator\":\"GREAT_THAN_EQUALS_TO\",\"values\":[\"" + date.AddDays(-(int)DateTime.Now.DayOfWeek - 6).ToString("yyyy-MM-dd") + "\"]},{\"column\":\"TimeStamp\",\"operator\":\"LESS_THAN_EQUALS_TO\",\"values\":[\"" + date.AddDays(-(int)DateTime.Now.DayOfWeek).ToString("yyyy-MM-dd") + "\"]}";
                else if (qTimeFilter == "previousmonth")
                {
                    DateTime firstDayOfLastMonth = new DateTime(date.Year, date.AddMonths(-1).Month, 1);
                    timeFrameFilter = "[{\"column\":\"TimeStamp\",\"operator\":\"GREAT_THAN_EQUALS_TO\",\"values\":[\"" + firstDayOfLastMonth.ToString("yyyy-MM-dd") + "\"]},{\"column\":\"TimeStamp\",\"operator\":\"LESS_THAN_EQUALS_TO\",\"values\":[\"" + firstDayOfLastMonth.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd") + "\"]}";
                }
            }

            if (qAnyDayFilter != "")
                anyDayFilter = "[{\"column\":\"TimeStamp\",\"operator\": \"EQUALS\",\"values\": [\"" + qAnyDayFilter + "\"]}";

            if (qFromDateFilter != "" && qToDateFilter != "")
                dateRangeFilter = "[{\"column\":\"TimeStamp\",\"operator\":\"GREAT_THAN_EQUALS_TO\",\"values\":[\"" + qFromDateFilter + "\"]},{\"column\":\"TimeStamp\",\"operator\":\"LESS_THAN_EQUALS_TO\",\"values\":[\"" + qToDateFilter + "\"]}";

            if (qCampaignFilter != "null" && qCampaignFilter != "")
            {
                string[] campaigns = qCampaignFilter.Split(",");
                foreach (var item in campaigns)
                    sbSplitFilter.Append("\"" + item + "\",");
                campaignFilter = "{\"column\":\"Campaign\",\"operator\": \"IN\",\"values\": [" + sbSplitFilter.ToString().Remove(sbSplitFilter.Length - 1, 1) + "]}";
            }

            if (qCallTypeFilter != "null" && qCallTypeFilter != "")
            {
                sbSplitFilter.Clear();
                string[] callTypes = qCallTypeFilter.Split(",");
                foreach (var item in callTypes)
                    sbSplitFilter.Append("\"" + item + "\",");
                callTypeFilter = "{\"column\":\"CALL_TYPE\",\"operator\": \"IN\",\"values\": [" + sbSplitFilter.ToString().Remove(sbSplitFilter.Length - 1, 1) + "]}";
            }

            if (qSkillFilter != "null" && qSkillFilter != "")
            {
                sbSplitFilter.Clear();
                string[] skills = qSkillFilter.Split(",");
                foreach (var item in skills)
                    sbSplitFilter.Append("\"" + item + "\",");
                skillFilter = "{\"column\":\"Skill\",\"operator\": \"IN\",\"values\": [" + sbSplitFilter.ToString().Remove(sbSplitFilter.Length - 1, 1) + "]}";
            }

            if (qAgentGroupFilter != "null" && qAgentGroupFilter != "")
            {
                string[] agentGroups = qAgentGroupFilter.Split(",");
                foreach (var item in agentGroups)
                    sbSplitFilter.Append("\"" + item + "\",");
                agentGroupFilter = "{\"column\":\"AGENT_GROUP\",\"operator\": \"IN\",\"values\": [" + sbSplitFilter.ToString().Remove(sbSplitFilter.Length - 1, 1) + "]}";
            }

            if (qAgentFilter != "null" && qAgentFilter != "")
            {
                string[] agents = qAgentFilter.Split(",");
                foreach (var item in agents)
                    sbSplitFilter.Append("\"" + item + "\",");
                agentFilter = "{\"column\":\"Agent\",\"operator\": \"IN\",\"values\": [" + sbSplitFilter.ToString().Remove(sbSplitFilter.Length - 1, 1) + "]}";
            }

            //if (qCampaignTypeFilter != "null" && qCampaignTypeFilter != "")
            //{
            //    string[] campaignTypes = qCampaignTypeFilter.Split(",");
            //    foreach (var item in campaignTypes)
            //        sbSplitFilter.Append("\"" + item + "\",");
            //    campaignTypeFilter = "{\"column\":\"CAMPAIGN_TYPE\",\"operator\": \"IN\",\"values\": [" + sbSplitFilter.ToString().Remove(sbSplitFilter.Length - 1, 1) + "]}";
            //}

            if (qTimeFilter != "" && qAnyDayFilter == "" && qFromDateFilter == "" && qToDateFilter == "")
                sbFilters.Append(timeFrameFilter + ",");
            if (qAnyDayFilter != "")
                sbFilters.Append(anyDayFilter + ",");
            if (qFromDateFilter != "" && qToDateFilter != "")
                sbFilters.Append(dateRangeFilter + ",");
            if (qCampaignFilter != "null" && qCampaignFilter != "")
                sbFilters.Append(campaignFilter + ",");
            if (qCallTypeFilter != "" && qCallTypeFilter != "null")
                sbFilters.Append(callTypeFilter + ",");
            if (qSkillFilter != "" && qSkillFilter != "null")
                sbFilters.Append(skillFilter + ",");
            if (qAgentGroupFilter != "" && qAgentGroupFilter != "null")
                sbFilters.Append(agentGroupFilter + ",");
            if (qAgentFilter != "" && qAgentFilter != "null")
                sbFilters.Append(agentFilter + ",");

            if (sbFilters.Length > 0)
            {
                filters = sbFilters.ToString().Remove(sbFilters.Length - 1, 1) + ",{\"column\":\"CAMPAIGN_TYPE\",\"operator\": \"EQUALS\",\"values\": [\"Outbound\"]}" + "]";
            }

            //programmaticFilter.Filter = filters;

            var accessToken = await domoHttpClient.GetAccessTokenAsync(clientDashboard.DomoClientID, clientDashboard.DomoClientSecretID);
            embedToken = await domoHttpClient.GetEmbedToken(accessToken, clientDashboard.DashboardEmbedId, filters);
        }
    }
}