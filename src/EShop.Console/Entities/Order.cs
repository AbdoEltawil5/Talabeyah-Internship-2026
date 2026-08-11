using EShop.Console.Entities.Enums;
using EShop.Console.Interfaces;

namespace EShop.Console.Entities;

public class Order : ISummarizable
{
    public Order(Guid id, Guid customerId, List<OrderItem>? orderItems, OrderStatus orderStatus = OrderStatus.Pending)
    {
        Id = id;
        CustomerId = customerId;
        OrderStatus = orderStatus;
        CreatedAt =  DateTime.UtcNow;
        OrderItems = orderItems ?? new List<OrderItem>();
        TotalAmount = GetTotalAmount();
    }

    public Guid Id { get; set; }
    public Guid CustomerId { get; }
    public OrderStatus OrderStatus { get; }
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
                Current Status: {OrderStatus}
                ======================
                TotalAmount: {TotalAmount}
                ----------------------
                """;
    }
}