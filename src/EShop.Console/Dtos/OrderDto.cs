using EShop.Console.Entities;
using EShop.Console.Entities.Enums;

namespace EShop.Console.Dtos;

public class OrderDto
{
    public OrderDto(Guid customerId, List<OrderItemDto> orderItemsDto, Status status = Entities.Enums.Status.Pending)
    {
        CustomerId = customerId;
        Status = status;
        OrderItemsDto = orderItemsDto;
    }
    public Guid CustomerId  { get; set; }
    public Status? Status { get; set; }
    public List<OrderItemDto> OrderItemsDto { get; set; }
        
}