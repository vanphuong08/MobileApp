﻿using Microsoft.EntityFrameworkCore;

namespace LabMobile.Models

{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("connectionString"));
        }
        public DbSet<Staff> staff { get; set; }

        public DbSet<User> user { get; set; }
    }
}
