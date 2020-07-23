

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


        //Um pedido dever ter 1 ou mais items do pedido
        
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
