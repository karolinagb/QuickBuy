using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities.ValuableObject;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class PaymentFormConfiguration : IEntityTypeConfiguration<PaymentForm>
    {
        public void Configure(EntityTypeBuilder<PaymentForm> builder)
        {
            builder.HasKey(paymentForm => paymentForm.Id);

            builder
                .Property(paymentForm => paymentForm.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(paymentForm => paymentForm.Description)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
