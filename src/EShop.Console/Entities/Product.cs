namespace EShop.Console.Entities;

public class Product
{
    public Product(string name, decimal price, Guid categoryId, int stockQuantity, string? description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        CategoryId = categoryId;
        StockQuantity = stockQuantity;
        Description = description;
    }
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public Guid CategoryId { get; set; }
}