namespace EShop.Console.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? ParentCategoryId { get; set; }
    public List<Category> subcategories { get; set; }
}