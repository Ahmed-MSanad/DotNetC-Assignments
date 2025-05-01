namespace Domain.Entities.OrderEntities
{
    public class OrderItem : BaseEntity<Guid>
    {
        public ProductInOrderItem product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
