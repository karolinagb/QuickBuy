using System.Collections.Generic;

namespace QuickBuy.Dominio.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //Usuario pode fazer nenhum ou muitos pedidos:
        public ICollection<Request> Requests { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AddValidationMessage("Email not informed");
            }

            if (string.IsNullOrEmpty(Password))
            {
                AddValidationMessage("Password not informed");
            }
        }
    }
}
