using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProgrammaticFiltering.Models;

namespace ProgrammaticFiltering
{
    [Authorize(Roles = "Executive")]
    public class InboundModel : PageModel
    {
        private DatavaultAccessLayer _dataAccessLayer;
        public IEnumerable<string> campaignsFilter;
        public IEnumerable<string> callTypeFilter;
        public IEnumerable<string> skillFilter;
        public IEnumerable<string> agentGroupFilter;
        public IEnumerable<string> agentFilter;

        public InboundModel(DatavaultAccessLayer dataAccessLayer)
        {
            _dataAccessLayer = dataAccessLayer;
        }

        public void OnGet()
        {
            campaignsFilter = _dataAccessLayer.GetDistinctCampaigns();
            callTypeFilter = _dataAccessLayer.GetDistinctCallTypes();
            skillFilter = _dataAccessLayer.GetDistinctSkills();
            agentGroupFilter = _dataAccessLayer.GetDistinctAgentGroups();
            agentFilter = _dataAccessLayer.GetDistinctAgents();
        }
    }
}