using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MQtraining.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> modelBuilder)
        {
            modelBuilder
                .HasKey(order => order.OrderId);

            modelBuilder
                .HasMany(order => order.LineItems)
                .WithOne(lineItem => lineItem.Order);
        }
    }
}
