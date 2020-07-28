using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProgrammaticFiltering.Models;

namespace ProgrammaticFiltering
{
    [Authorize(Roles = "Executive,Supervisor")]
    public class UserGroupModel : PageModel
    {
        private readonly ILogger<UserGroupModel> _logger;
        private DatavaultAccessLayer _dataAccessLayer;
        public IEnumerable<string> campaignsFilter;
        public IEnumerable<string> callTypeFilter;
        public IEnumerable<string> skillFilter;
        public IEnumerable<string> agentGroupFilter;
        public IEnumerable<string> agentFilter;
        public IEnumerable<string> campaignTypeFilter;


        public UserGroupModel(ILogger<UserGroupModel> logger, DatavaultAccessLayer dataAccessLayer)
        {
            _logger = logger;
            _dataAccessLayer = dataAccessLayer;
        }

        public void OnGet()
        {
            //campaignsFilter = _dataAccessLayer.GetDistinctCampaigns();
            //callTypeFilter = _dataAccessLayer.GetDistinctCallTypes();
            //skillFilter = _dataAccessLayer.GetDistinctSkills();
            //agentGroupFilter = _dataAccessLayer.GetDistinctAgentGroups();
            //agentFilter = _dataAccessLayer.GetDistinctAgents();
            //campaignTypeFilter = _dataAccessLayer.GetDistinctCampaignTypes();
        }
    }
}