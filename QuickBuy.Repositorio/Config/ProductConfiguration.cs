using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);

            builder
                .Property(product => product.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(product => product.Description)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(product => product.Price)
                .HasColumnType("decimal(19,4)")
                .IsRequired();
        }
    }
}
