using EShop.Console.Entities;

namespace EShop.Console.Repositories.Interfaces;

public interface IOrderRepository
{
    IEnumerable<Order> GetAll();
    Guid Add(Order order);
}