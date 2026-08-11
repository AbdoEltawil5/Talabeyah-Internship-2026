using EShop.Console.Abstractions;

namespace EShop.Console.Entities;

public class Customer : ISummarizable
{
    public Customer(int id, string name, string email, string passwordHash)
    {
        Id = id;
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
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
    
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (value.Length <= 2)
            {
                throw new Exception("Customer name char number should be more than 2 chars.");
            }
            _name = value;
        }
    }

    private readonly string _email;
    private string Email
    {
        get => _email;
        init
        {
            if (!value.Contains('@') || value.Length < 5)
            {
                throw new Exception("Please Enter a Valid Email");
            }
            _email = value;
        }
    }

    private string _passwordHash;
    public string PasswordHash
    {
        get => _passwordHash;
        set
        {
            if (value.Length <= 6)
            {
                throw new Exception("Password Should be more then 6 chars");
            }
            _passwordHash = value;
        }
    }

    public string SummarizeEntityData()
    {
        return $"Id {Id}, Name {Name}, Email {Email}";
    }
}