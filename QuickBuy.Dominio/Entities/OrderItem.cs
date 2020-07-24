namespace QuickBuy.Dominio.Entities
{
    public class OrderItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            //Id de Produto nao pode ser vazio
            if(ProductId == 0)
            {
                AddValidationMessage("Product reference not found");
            }

            if (Quantity == 0)
            {
                AddValidationMessage("Quantity not informed");
            }
        }
    }
}
