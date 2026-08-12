using EShop.Console.Abstractions;

namespace EShop.Console.DbContext;

public class AppDbContext : IAppDbContext
{
    public bool SaveChanges()
    {
        System.Console.WriteLine("changes saved successfully");
        return true;
    }
}