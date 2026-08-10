using EShop.Console.Abstractions;

namespace EShop.Console.Entities;

public class Order : ISummarizable
{
    public Order(int id, int customerId, string status, double totalAmount)
    {
        Id = id;
        CustomerId = customerId;
        Status = status;
        TotalAmount = totalAmount;
        _createdAt = DateTime.Now;
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

    private string _status;
    public string Status
    {
        get => _status;
        set
        {
            if (value.Length <= 2)
            {
                throw new Exception("user name char number should be more than 2 chars.");
            }
            _status = value;
            _createdAt = DateTime.Now;
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
            _createdAt = DateTime.Now;
        }
    }

    private DateTime _createdAt;
    public DateTime CreatedAt => _createdAt;
    public string Summarize()
    {
        return $"Id {Id}, customerId {CustomerId}, Status {Status}, TotalAmount {TotalAmount}";
    }
}