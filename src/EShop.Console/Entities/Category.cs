using EShop.Console.Abstractions;

namespace EShop.Console.Entities;

public class Category
{
    public Category(int id, string name, List<Category> subcategories)
    {
        Id = id; Name = name;
        Subcategories = subcategories;
    }
    public Category(int id, string name, int parentCategoryId, List<Category> subcategories)
    {
        Id = id; Name = name;
        Subcategories = subcategories;
        ParentCategoryId = parentCategoryId;
    }
    
    private readonly int _id;
    public int Id
    {
        get => _id;
        init
        {
            if (value <= 0)
            {
                throw new Exception("Id should be higher than zero.");
            }
            _id = value;
        }
    }

    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (value.Length <= 2)
            {
                throw new Exception("Category name char number should be more than 2 chars.");
            }
            _name = value;
        }
    }
    
    private int? _parentCategoryId;
    public int? ParentCategoryId
    {
        get => _parentCategoryId;
        set
        {
            if (value <= 0)
            {
                throw new Exception("ParentCategoryId should be higher than zero.");
            }
            _parentCategoryId = value;
        }
    }
    
    private List<Category> _subcategories;
    public List<Category> Subcategories
    {
        get => _subcategories;
        set
        {
            if (value.Count == 0)
            {
                throw new Exception("subcategories Length should be higher than zero.");
            }
            _subcategories = value;
        }
    }

    public override string ToString()
    {
        return $"Id {Id} Name {Name}";
    }
}