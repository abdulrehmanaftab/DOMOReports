using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ProgrammaticFiltering.Models;

namespace ProgrammaticFiltering
{
    public class ProgrammaticFilteringService : IProgrammaticFilteringService
    {        
        private Dictionary<string, ProgrammaticFilter> filters = new Dictionary<string, ProgrammaticFilter>();

        public ProgrammaticFilteringService() {

            filters.Add("executive@allshorestaffing.com",
                  new ProgrammaticFilter
                  {
                      ClientId = "14ec9374-a5aa-4c7d-8f4c-cb045c5d93b7",
                      ClientSecret = "61c9c7f8f906310208aa97c3a8ed0398670f8a9eeb577106836492d3cb0aaa90",
                      Filter = "[]"
                    //Filter = "[{\"column\": \"Agent_ID\",\"operator\": \"EQUALS\",\"values\": [\"3500495\"]}]",
                    //EmbedId = "eg1Nj"
                });
            filters.Add("supervisor@allshorestaffing.com",
                    new ProgrammaticFilter
                    {
                        ClientId = "14ec9374-a5aa-4c7d-8f4c-cb045c5d93b7",
                        ClientSecret = "61c9c7f8f906310208aa97c3a8ed0398670f8a9eeb577106836492d3cb0aaa90",
                        Filter = "[]",
                        EmbedId = "EMBED_ID",
                    });
            filters.Add("agent@allshorestaffing.com",
                    new ProgrammaticFilter
                    {
                        ClientId = "14ec9374-a5aa-4c7d-8f4c-cb045c5d93b7",
                        ClientSecret = "61c9c7f8f906310208aa97c3a8ed0398670f8a9eeb577106836492d3cb0aaa90",
                        Filter = "[]",
                        EmbedId = "EMBED_ID"
                    });
        }

        public ProgrammaticFilter getProgrammaticFilter(string username)
        {
            if (!filters.TryGetValue(username, out ProgrammaticFilter filter))
            {
                return new ProgrammaticFilter();
            }
            return filters[username];
        }
    }
}