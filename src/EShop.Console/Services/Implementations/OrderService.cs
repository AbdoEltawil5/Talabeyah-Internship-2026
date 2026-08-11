using EShop.Console.Dtos;
using EShop.Console.Entities;
using EShop.Console.Entities.Enums;
using EShop.Console.Repositories.Interfaces;
using EShop.Console.Services.Interfaces;

namespace EShop.Console.Services.Implementations;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Guid AddOrder(OrderDto orderDto)
    {
        var orderId = Guid.NewGuid();
        List<OrderItem> orderItems = new List<OrderItem>();
        foreach (var item in orderDto.OrderItemsDto)
        {
            var orderItem = new OrderItem(orderId, item.ProductId, item.UnitPrice, item.Discount, item.Quantity);
            orderItems.Add(orderItem);
        }

        Order order = new Order(orderId, orderDto.CustomerId, orderItems, orderDto.Status ?? Status.Pending);
        var newOrderId = _orderRepository.Add(order);
        
        return newOrderId;
    }
}