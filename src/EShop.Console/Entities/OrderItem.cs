namespace EShop.Console.Entities;

public class OrderItem
{
    public OrderItem(Guid orderId, Guid productId, decimal unitPrice, decimal discount, int quantity)
    {
        OrderId = orderId;
        ProductId = productId;
        UnitPrice = unitPrice;
        Discount = discount;
        Quantity = quantity;
    }
    public Guid OrderId { get; }
    public Guid ProductId { get; }
    public decimal UnitPrice { get; }
    public decimal Discount { get; }
    public int Quantity { get; }

    public decimal UnitPriceAfterDiscount()
    {
        return UnitPrice - Discount;
    }
}