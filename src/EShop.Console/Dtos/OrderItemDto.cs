namespace EShop.Console.Dtos;

public record OrderItemDto(Guid ProductId, decimal UnitPrice, decimal Discount);