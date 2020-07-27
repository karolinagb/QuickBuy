using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.Entities.ValuableObject;

namespace QuickBuy.Repositorio.Context
{
    class QuickBuyContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Request> Request { get; set; }

        public DbSet<OrderItem> OrderItem { get; set; }

        /*O PaymentForm é um objeto de valor, mas precisamos dele na base de dados:*/
        public DbSet<PaymentForm> PaymentForm { get; set; }
    }
}
