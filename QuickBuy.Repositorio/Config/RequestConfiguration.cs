using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasKey(request => request.Id);

            builder
                .Property(request => request.RequestDate)
                .IsRequired();

            builder
                .Property(request => request.ExpectedDeliveryDate)
                .IsRequired();

            builder
                .Property(request => request.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(request => request.City)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(request => request.State)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(request => request.CompleteAddress)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(request => request.AdressNumber)
                .IsRequired();

            /*Não há necessidade de configurar no lado pai também, mas se você quiser é assim que faz:*/
            builder.HasOne(request => request.User);

            builder.HasOne(request => request.PaymentForm);
        }
    }
}
