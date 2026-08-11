using EShop.Console.Entities;
using EShop.Console.Entities.Enums;

namespace EShop.Console.Dtos;

public record OrderDto(Guid CustomerId, List<OrderItemDto> OrderItemsDto, OrderStatus OrderStatus = OrderStatus.Pending);

