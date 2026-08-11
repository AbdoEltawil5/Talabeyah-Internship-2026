namespace EShop.Console.Dtos;

public class OrderItemDto
{
    public OrderItemDto(Guid productId, decimal unitPrice, decimal discount)
    {
        productId = ProductId;
        UnitPrice = unitPrice;
        Discount = discount;
    }
    
    public Guid ProductId { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
}