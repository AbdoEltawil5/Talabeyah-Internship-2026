using EShop.Console.ValueObjects;

namespace EShop.Console.Dtos;

public record ProductDto(string ProductName, Money UnitPrice, int StockQuantity);