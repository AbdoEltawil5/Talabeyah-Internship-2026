using EShop.Console.Entities;
using EShop.Console.Repositories.Interfaces;

namespace EShop.Console.Repositories.Implementations;

public class OrderRepository : IOrderRepository
{
    private List<Order> _orders;

    public OrderRepository()
    {
        _orders = new List<Order>();

        for (int i = 1; i <= 5; i++)
        {
            var order = new Order(Guid.NewGuid(), Guid.NewGuid(), null);
            var random = new Random();
            for (int j = 0; j < 3; j++)
            {
                var unitPrice = random.Next(10, 100);
                var discount = random.Next(1, unitPrice / 2);
                var quantity = random.Next(1, 100);
                var item = new OrderItem(order.Id, Guid.NewGuid(), unitPrice, discount, quantity);
                order.OrderItems.Add(item);
            }

            _orders.Add(order);
        }
    }

    public IEnumerable<Order> GetAll()
    {
        return _orders;
    }

    public Guid Add(Order order)
    {
        _orders.Add(order);
        return order.Id;
    }
}