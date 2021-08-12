using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MQtraining.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Data.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> modelBuilder)
        {
            modelBuilder
                .HasKey(item => item.ItemId);

            modelBuilder
                .HasMany(item => item.LineItems)
                .WithOne(lineItem => lineItem.Item);
        }
    }
}
