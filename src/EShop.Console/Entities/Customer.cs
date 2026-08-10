namespace EShop.Console.Entities;

public class Customer(int id, string name, string email, string passwordHash)
{
    private int _id;
    public int Id
    {
        get => _id;
        set
        {
            if (value <= 0)
            {
                throw new Exception("Id should be higher than zero.");
            }
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
                throw new Exception("user name char number should be more than 2 chars.");
            }
        }
    }

    private string _email;
    public string Email
    {
        get => _email;
        set
        {
            if (!value.Contains('@'))
            {
                throw new Exception("Please Enter a Valid Email");
            }
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
        }
    }
}