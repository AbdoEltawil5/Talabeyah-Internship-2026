using EShop.Console.Abstractions;
using EShop.Console.Shared;

namespace EShop.Console.Entities;

public class Cart : ISummarizable
{
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public List<CartItem> Items { get; private set; } = new();

    public Cart(Guid id, Guid customerId)
    {
        if (id == Guid.Empty)
            throw new ArgumentException("Id cannot be empty");

        if (customerId == Guid.Empty)
            throw new ArgumentException("CustomerId cannot be empty");

        Id = id;
        CustomerId = customerId;
    }

    public void AddItem(Guid productId, int quantity, Money price)
    {
        Items.Add(new CartItem(Guid.NewGuid(), Id, productId, quantity, price));
    }

    public void RemoveItem(Guid productId)
    {
        var item = Items.FirstOrDefault(i => i.ProductId == productId);
        if (item != null)
            Items.Remove(item);
    }

    public string Summarize()
    {
        return $"Cart has {Items.Count} items";
    }
}
