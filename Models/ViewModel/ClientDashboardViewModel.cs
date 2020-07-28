using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammaticFiltering.Models.ViewModel
{
    public class ClientDashboardViewModel
    {
        public int ClientID { get; set; }
        public string DashboardEmbedId { get; set; }
        public string DomoClientID { get; set; }
        public string DomoClientSecretID { get; set; }
    }
}
