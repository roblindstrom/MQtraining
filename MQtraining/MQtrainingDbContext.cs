﻿using Microsoft.EntityFrameworkCore;
using MQtraining.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.Data
{
    public class MQtrainingDbContext : DbContext
    {
        public MQtrainingDbContext(DbContextOptions<MQtrainingDbContext> options)
            :base(options)
        {
                
        }

        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MQtrainingDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
