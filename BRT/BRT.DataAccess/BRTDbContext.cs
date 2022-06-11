﻿using BRT.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRT.DataAccess
{
    public class BRTDbContext : DbContext
    {
        public BRTDbContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-Q6EIPDG;database=BRT;Trusted_Connection=True";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products{ get; set; }

    }
}
