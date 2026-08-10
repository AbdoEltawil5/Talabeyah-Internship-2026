namespace EShop.Console.Entities;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public Guid? ParentCategoryId { get; set; }
    public List<Category>? SubCategories { get; set; }
}