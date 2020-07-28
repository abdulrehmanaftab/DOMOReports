using Microsoft.AspNetCore.Identity;
using System;

namespace ProgrammaticFiltering.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int ClientId { get; set; }
    }
}
