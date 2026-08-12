namespace EShop.Console.Entities;

public class CartItem
{
    public CartItem(Guid cartId, Guid productId, decimal unitPrice, decimal discount )
    {
        CartId = cartId;
        ProductId = productId;
        UnitPrice = unitPrice;
        Discount = discount;
        CreatedAt = DateTime.UtcNow;
    }
    public Guid CartId { get; }
    public Guid ProductId { get; }
    public decimal UnitPrice { get; }
    public decimal Discount { get; }
    public DateTime CreatedAt { get; }
}