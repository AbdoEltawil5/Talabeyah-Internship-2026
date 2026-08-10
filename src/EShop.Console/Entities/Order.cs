namespace EShop.Console.Entities;

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string Status { get; set; }
    public double TotalAmount { get; set; }
    public DateOnly CreatedAt { get; set; }
}