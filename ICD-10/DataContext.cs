using System;
using ICD_10.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Application
{
    public class DataContext : DbContext
    {
        public DbSet<BillingCode> icd10codes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql("User ID=christineong;Host=localhost;Port=5432;Database=christineong;");
        }
    }
}
