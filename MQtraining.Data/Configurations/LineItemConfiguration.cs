using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MQtraining.Shared.Models;

namespace MQtraining.Data.Configurations
{

    public class LineItemConfiguration : IEntityTypeConfiguration<LineItem>
    {
        public void Configure(EntityTypeBuilder<LineItem> modelBuilder)
        {
            modelBuilder
                .HasKey(lineItem => lineItem.LineItemId);

            modelBuilder
                .HasOne(lineItem => lineItem.Order)
                .WithMany(order => order.LineItems);

            modelBuilder
                .HasOne(lineItem => lineItem.Item)
                .WithMany(items => items.LineItems);
        }
    }
}
