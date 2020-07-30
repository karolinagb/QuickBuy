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
            throw new NotImplementedException();
        }
    }
}
