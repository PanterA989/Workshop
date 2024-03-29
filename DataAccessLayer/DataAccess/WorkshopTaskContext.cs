﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Workshop.DataAccessLayer.DatabaseConnection;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;

namespace Workshop.DataAccessLayer.DataAccess
{
    public class WorkshopTaskContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionHelper.GetConnectionString());
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<WorkshopTask> WorkshopTasks { get; set; }
        public DbSet<WorkshopTaskStatus> WorkshopTaskStatuses { get; set; }
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
