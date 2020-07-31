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
        public virtual ICollection<Request> Requests { get; set; }
        /*Para fazer o mapeamento do relacionamento 1 para muitos, existe o método da convenção, onde o EF Core faz o mapeamento para
         nós só que temos que seguir alguma regras. Exemplo: Como acima que colocamos o nome virtual antes da propriedade pois assim
        eu dou permissão ao EF Core de sobrescrever essa propriedade, colocando itens nela, em tempo de execução (já que ela foi
        definida como vazia.
        Depois tenho que navegar para o pedido e configurar o retorno da instância de pedido para usuário.*/

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
