using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProgrammaticFiltering.Data;
using ProgrammaticFiltering.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProgrammaticFiltering.Pages
{
    [Authorize(Roles = "Executive")]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private DatavaultAccessLayer _datavaultAccessLayer;
        private ApplicationUserDataAccessLayer _applicationUserDataAccessLayer;
        public IEnumerable<string> campaignsFilter;
        public IEnumerable<string> callTypeFilter;
        public IEnumerable<string> skillFilter;
        public IEnumerable<string> agentGroupFilter;
        public IEnumerable<string> agentFilter;
        public IEnumerable<string> campaignTypeFilter;


        public IndexModel(ILogger<IndexModel> logger,DatavaultAccessLayer dataAccessLayer, 
            ApplicationUserDataAccessLayer applicationUserDataAccessLayer)
        {
            _logger = logger;
            _datavaultAccessLayer = dataAccessLayer;
            _applicationUserDataAccessLayer = applicationUserDataAccessLayer;
        }

        public void OnGet()
        {
            campaignsFilter = _datavaultAccessLayer.GetDistinctCampaigns();
            callTypeFilter = _datavaultAccessLayer.GetDistinctCallTypes();
            skillFilter = _datavaultAccessLayer.GetDistinctSkills();
            agentGroupFilter = _datavaultAccessLayer.GetDistinctAgentGroups();
            agentFilter = _datavaultAccessLayer.GetDistinctAgents();
            campaignTypeFilter = _datavaultAccessLayer.GetDistinctCampaignTypes();

        }
    }
}
