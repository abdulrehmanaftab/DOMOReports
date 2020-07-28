using ProgrammaticFiltering.Data;
using ProgrammaticFiltering.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammaticFiltering.Models
{
    public class ApplicationUserDataAccessLayer
    {
        private readonly ApplicationDbContext _dbContext;
        public ApplicationUserDataAccessLayer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ClientDashboardViewModel GetClientDashboardByClientIdAndDashboardType(int clientId, string dashboardType)
        {
            try
            {
                var clientDashboard = (from cldash in _dbContext.ClientDashboards
                                       join client in _dbContext.Clients on cldash.client_id equals client.client_id
                                       where cldash.client_id == clientId && cldash.client_dashboard_type == dashboardType
                                       select new ClientDashboardViewModel
                                       {
                                           ClientID = cldash.client_id,
                                           DashboardEmbedId = cldash.dashboard_embed_id,
                                           DomoClientID = client.domo_client_id.ToString(),
                                           DomoClientSecretID = client.domo_client_secret
                                       }).FirstOrDefault();

                return clientDashboard;
            }
            catch
            {
                throw;
            }
        }

        public Clients GetClientById(int clientId)
        {
            try
            {
                return _dbContext.Clients.Where(m => m.client_id == clientId).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

    }
}
