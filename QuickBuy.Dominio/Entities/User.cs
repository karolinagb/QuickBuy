using System.Collections.Generic;

namespace QuickBuy.Dominio.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //Usuario pode fazer nenhum ou muitos pedidos:
        public ICollection<Request> Requests { get; set; }
    }
}
