using EShop.Console.Entities.Enums;
using EShop.Console.Interfaces;

namespace EShop.Console.Entities;

public class Order : ISummarizable
{
    public Order(Guid id, Guid customerId, List<OrderItem>? orderItems, Status status = Status.Pending)
    {
        Id = id;
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

    public string Summarize()
    {
        return $"""
                ----------------------
                Order #{Id} 
                Created at: {CreatedAt}
                Current Status: {Status}
                ======================
                TotalAmount: {TotalAmount}
                ----------------------
                """;
    }
}