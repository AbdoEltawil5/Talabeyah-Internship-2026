namespace EShop.Console.Abstractions;

public interface IAppDbContext
{
    public bool SaveChanges();
}