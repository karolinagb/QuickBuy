using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(orderItem => orderItem.Id);

            builder
                .Property(orderItem => orderItem.ProductId)
                .IsRequired();

            builder
                .Property(orderItem => orderItem.Quantity)
                .IsRequired();
        }
    }
}
