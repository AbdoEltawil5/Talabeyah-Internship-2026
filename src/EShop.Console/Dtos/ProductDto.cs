using EShop.Console.Shared;

namespace EShop.Console.Dtos;

public record ProductDto(string Name, Money UnitPrice, int StockQuantity);