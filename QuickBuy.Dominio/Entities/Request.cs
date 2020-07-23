

using QuickBuy.Dominio.Entities.ValuableObject;
using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public int UserId { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string CompleteAddress { get; set; }
        public string AdressNumber { get; set; }

        //Id do forma de pagamento:
        public int PaymentFormId { get; set; }

        //Forma de pagamento:
        public PaymentForm PaymentForm { get; set; }

        //Um pedido dever ter 1 ou mais items de pedido
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
