namespace EShop.Console.Entities;

public class Cart
{
    public Cart(Guid customerId, List<CartItem>? items)
    {
        Id = Guid.NewGuid();
        CustomerId = customerId;
        Items = items ?? new List<CartItem>();
    }
    public Guid Id { get; }
    public Guid CustomerId { get; }
    public List<CartItem> Items { get; }
}