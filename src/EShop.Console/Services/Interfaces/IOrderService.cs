using EShop.Console.Dtos;
using EShop.Console.Entities;

namespace EShop.Console.Services.Interfaces;

public interface IOrderService
{
    Guid AddOrder(OrderDto orderDto);
}