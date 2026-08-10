namespace EShop.Console.Entities;

public class CartItem
{
    public Guid CartId { get; set; }
    public Guid ProductId { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public DateTime CreatedAt { get; set; }
}