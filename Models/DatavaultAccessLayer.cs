using Microsoft.EntityFrameworkCore;
using ProgrammaticFiltering.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammaticFiltering.Models
{
    public class DatavaultAccessLayer
    {
        private readonly DataVaultContext _dbContext;
        enum clients
        {
            VictoryLap
        }

        public DatavaultAccessLayer(DataVaultContext dbContext)
        {
            _dbContext = dbContext;

        }

        public IEnumerable<string> GetDistinctCampaigns()
        {
            try
            {
                return _dbContext.VlapDomocallLog.Where(m => m.Campaign != null).Select(m => m.Campaign).Distinct().ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<string> GetDistinctCallTypes()
        {
            try
            {
                return _dbContext.VlapDomocallLog.Where(m => m.CallType != null).Select(m => m.CallType).Distinct().ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<string> GetDistinctSkills()
        {
            try
            {
                return _dbContext.VlapDomocallLog.Where(m => m.Skill != null).Select(m => m.Skill).Distinct().ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<string> GetDistinctAgentGroups()
        {
            try
            {
                return _dbContext.VlapDomocallLog.Where(m => m.AgentGroup != null).Select(m => m.AgentGroup).Distinct().ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<string> GetDistinctCampaignTypes()
        {
            try
            {
                return _dbContext.VlapDomocallLog.Where(m => m.CampaignType != null).Select(m => m.CampaignType).Distinct().ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<string> GetDistinctAgents()
        {
            try
            {
                return _dbContext.VlapDomocallLog.Where(m => m.Agent != null).Select(m => m.Agent).Distinct().ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
