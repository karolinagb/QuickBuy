

using QuickBuy.Dominio.Entities.ValuableObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entities
{
    public class Request : Entity
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }

        /*Para realizar o mapeamento por convenção tenho que colocar a propriedade user dentro de pedido. Lembrando de também
         acrescentar o nome virtual:*/
        public virtual User User { get; set; }
        public int UserId { get; set; }
        /*No caso do mapeamento por convenção, no lado 1 (1-n) tenho que por a propriedade com o mesmo nome da entidade (user) e tenho
         que ter um id com o primeiro nome sendo igual ao da propriedade mapeada e o segundo nome deve ser a chave primária que tem
        na classe User.*/

        public DateTime ExpectedDeliveryDate { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string CompleteAddress { get; set; }
        public string AdressNumber { get; set; }

        //Id do forma de pagamento:
        public int PaymentFormId { get; set; }

        //Forma de pagamento:
        public virtual PaymentForm PaymentForm { get; set; }

        //Um pedido dever ter 1 ou mais items de pedido
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public override void Validate()
        {
            //Toda vez q eu chamo o Validate, eu chamo o ClearValidationMessages para limpar e add novas mensagens
            ClearValidationMessages();

            //Um pedido não poder vir com item de pedido vazio
            //Any = serve para falar se existe algum registro no banco com a condição que for colocada nele:
            if (!OrderItems.Any())
            {
                AddValidationMessage("Request cannot be without order item");
            }

            //CEP não pode ser vazio:
            if (string.IsNullOrEmpty(CEP))
            {
                AddValidationMessage("CEP can not be empty");
            }

            if(PaymentFormId == 0)
            {
                AddValidationMessage("Payment form not found");
            }
        }
    }
}
