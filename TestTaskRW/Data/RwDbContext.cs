using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestTaskRW.Models;
using Microsoft.AspNetCore.Identity;
using TestTaskRW.Data;

namespace TestTaskRW
{
    public class RwDbContext : IdentityDbContext<Models.User>
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Organisation> Organisations { get; set; }

        public RwDbContext(DbContextOptions<RwDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var dbinitializer = new DbInitializer();
            base.OnModelCreating(builder);
            dbinitializer.SeedOrganisations(builder);
            dbinitializer.SeedDepartments(builder);
            dbinitializer.SeedRoles(builder);
            dbinitializer.SeedUsers(builder);
            dbinitializer.SeedUserRoles(builder);
        }

    }
}
