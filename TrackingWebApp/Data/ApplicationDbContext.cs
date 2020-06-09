using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using TrackingApp.Models;

namespace TrackingWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                }
             );
            builder.Entity<TrackingApp.Models.Project>()
                .HasData(

                new TrackingApp.Models.Project
                {
                    Id = 1,
                    Title = "Roof",
                    Mileage = 50,
                    Budget = 1000,
                    BudgetUsed = 500
                }); ;
        }

        public DbSet<TrackingApp.Models.Project> Projects {get; set;}
        public DbSet<Expense> Expenses { get; set; }

        public DbSet<HoursSpent> HoursSpent { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<Receipt> Receipts { get; set; }


    }
}
