using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProgrammaticFiltering.Models;

namespace ProgrammaticFiltering.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProgrammaticFiltering.Models.Clients> Clients { get; set; }
        public DbSet<ProgrammaticFiltering.Models.ClientDashboards> ClientDashboards { get; set; }
    }
}
