using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                AddValidationMessage("Product Name not found");
            }

            if (string.IsNullOrEmpty(Description))
            {
                AddValidationMessage("Description not informed");
            }
        }
    }
}
