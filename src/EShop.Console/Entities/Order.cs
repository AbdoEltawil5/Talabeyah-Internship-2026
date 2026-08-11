using EShop.Console.Abstractions;
using EShop.Console.Enums;

namespace EShop.Console.Entities;

public class Order : ISummarizable
{
    public Order(int id, int customerId, Status status, double totalAmount)
    {
        Id = id;
        CustomerId = customerId;
        Status = status;
        TotalAmount = totalAmount;
        CreatedAt = DateTime.Now;
    }
    private readonly int _id;
    private int Id
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
    
    private readonly int _customerId;
    private int CustomerId
    {
        get => _customerId;
        init
        {
            if (value <= 0)
            {
                throw new Exception("CustomerId should be higher than zero.");
            }
            _customerId = value;
        }
    }

    private Status _status;
    public Status Status
    {
        get => _status;
        set
        {
            if (value != Status.Arrived && value != Status.Pending && value != Status.Ready)
            {
                throw new Exception("Please enter a valid order Status.");
            }
            _status = value;
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
    public string SummarizeEntity()
    {
        return $"Id {Id}, customerId {CustomerId}, Status {Status}, TotalAmount {TotalAmount}";
    }
}