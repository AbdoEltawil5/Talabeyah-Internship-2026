namespace EShop.Console.Entities;

public class Customer
{
    public Customer(string name, string email, string password)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        setPassword(password);
    }
    public Guid Id { get; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PasswordHash { get; private set; } = null!;

    public void setPassword(string password)
    {
        PasswordHash = password + "Hashed";
    }
    
}