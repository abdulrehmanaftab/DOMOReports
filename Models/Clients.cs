using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace ProgrammaticFiltering.Models
{
    public class Clients
    {
        [Key]
        public int client_id { get; set; }
        public string domo_client_id { get; set; }
        public string domo_client_secret { get; set; }
        public string client_name { get; set; }
    }
}
