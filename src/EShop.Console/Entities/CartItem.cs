namespace EShop.Console.Entities;

public class CartItem
{
    public Guid Id { get; private set; }
    public Guid CartId { get; private set; }
    public Guid ProductId { get; private set; }
    public int Quantity { get; private set; }
    public decimal Price { get; set; }

    public CartItem(Guid id, Guid cartId, Guid productId, int quantity, decimal price)
    {
        Id = id;
        CartId = cartId;
        ProductId = productId;
        Quantity = quantity;
        Price = price;
    }
}
