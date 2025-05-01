namespace Domain.Entities.OrderEntities
{
    public class Order : BaseEntity<Guid>
    {
        public string BuyerEmail { get; set; }
        public Address ShippingAddress { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public OrderPaymentStatus PaymentStatus { get; set; } = OrderPaymentStatus.Pending;
        public DeliveryMethod DeliveryMethod { get; set; }
        public int? DeliveryMethodId { get; set; }
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now; // DateTimeOffset -> adds the zone besides the date
        public decimal SubTotal { get; set; } // Quatity of the OrderItems * Price => without the shipping price
    }
}
