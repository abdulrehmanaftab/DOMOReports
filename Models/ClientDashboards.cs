using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammaticFiltering.Models
{
    public class ClientDashboards
    {
        [Key]
        public int client_dashboard_id { get; set; }
        public int client_id { get; set; }
        public string client_dashboard_type { get; set; }
        public string dashboard_embed_id { get; set; }
    }
}
