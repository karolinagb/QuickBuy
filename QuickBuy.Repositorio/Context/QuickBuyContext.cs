using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.Entities.ValuableObject;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Context
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Request> Request { get; set; }

        public DbSet<OrderItem> OrderItem { get; set; }

        /*O PaymentForm é um objeto de valor, mas precisamos dele na base de dados:*/
        public DbSet<PaymentForm> PaymentForm { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de mapeamento aqui:
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RequestConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentFormConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());

            modelBuilder.Entity<PaymentForm>().HasData(
                new PaymentForm() {
                    Id = 1, 
                    Name = "Boleto", 
                    Description = "Forma de pagamento Boleto" 
                },
                new PaymentForm()
                {
                    Id = 2,
                    Name = "Cartão de Crédito",
                    Description = "Forma de pagamento Cartão de Crédito"
                },
                new PaymentForm()
                {
                    Id = 3,
                    Name = "Depósito",
                    Description = "Forma de pagamento Depósito"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
