using EShop.Console.Abstractions;
using EShop.Console.Enums;

namespace EShop.Console.Entities;

public class Order : ISummarizable
{
    public Order(int id, int customerId, OrderStatus orderStatus, double totalAmount)
    {
        Id = id;
        CustomerId = customerId;
        OrderStatus = orderStatus;
        TotalAmount = totalAmount;
        CreatedAt = DateTime.Now;
    }
    private readonly int _id;
    public int Id
    {
        get => _id;
        init
        {
            if (value <= 0)
            {
                throw new Exception("Id should be higher than zero.");
            }
            _id = value;
        }
    }
    
    private int _customerId;
    public int CustomerId
    {
        get => _customerId;
        set
        {
            if (value <= 0)
            {
                throw new Exception("CustomerId should be higher than zero.");
            }
            _customerId = value;
        }
    }

    private OrderStatus _orderStatus;
    public OrderStatus OrderStatus
    {
        get => _orderStatus;
        set
        {
            if (!Enum.IsDefined(typeof(OrderStatus), value))
            {
                throw new Exception("Please enter a valid order Status.");
            }
            _orderStatus = value;
        }
    }

    private double _totalAmount;
    public double TotalAmount
    {
        get => _totalAmount;
        set
        {
            if (value <= 0)
            {
                throw new Exception("TotalAmount Should be higher than zero.");
            }
            _totalAmount = value;
        }
    }
    public DateTime CreatedAt { get; }
    public string SummarizeData()
    {
        return $"Id {Id}, customerId {CustomerId}, Status {OrderStatus}, TotalAmount {TotalAmount}";
    }
}