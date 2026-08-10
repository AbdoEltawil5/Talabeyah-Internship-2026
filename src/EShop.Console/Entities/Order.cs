using EShop.Console.Entities.Enums;

namespace EShop.Console.Entities;

public class Order
{
    public Order(Guid customerId, Status status, List<OrderItem>? orderItems)
    {
        Id = Guid.NewGuid();
        CustomerId = customerId;
        Status = status;
        CreatedAt =  DateTime.UtcNow;
        TotalAmount = GetTotalAmount();
        OrderItems = orderItems ?? new List<OrderItem>();
    }

    public Guid Id { get; set; }
    public Guid CustomerId { get; }
    public Status Status { get; set; }
    public decimal TotalAmount { get; }
    public DateTime CreatedAt { get; }
    public List<OrderItem> OrderItems { get; }
    
    private decimal GetTotalAmount()
    {
        return OrderItems.Sum(oi => oi.UnitPriceAfterDiscount());
    }
}