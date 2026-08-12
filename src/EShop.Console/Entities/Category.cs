namespace EShop.Console.Entities;

public class Category
{
    public Category(string name, Guid? parentCategoryId)
    {
        Id = Guid.NewGuid();
        Name = name;
        ParentCategoryId = parentCategoryId;
    }
    
    public Guid Id { get; }
    public string Name { get; set; } = null!;
    public Guid? ParentCategoryId { get; set; }
    public List<Category>? SubCategories { get; set; }
}