namespace EShop.Console.Entities;

public class Product
{
    private readonly int _id;
    private int Id
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
                throw new Exception("Product name char number should be more than 2 chars.");
            }
            _name = value;
        }
    }
    private string _description;
    public string Description
    {
        get => _description;
        set
        {
            if (value.Length <= 10)
            {
                throw new Exception("Description char number should be more than 10 chars.");
            }
            _description = value;
        }
    }

    private double _price;
    public double Price
    {
        get => _price;
        set
        {
            if (value < 0)
            {
                throw new Exception("Price shouldn't be lower than 0");
            }
            _price = value;
        }
    }

    private int _stockQuantity;
    public int StockQuantity
    {
        get => _stockQuantity;
        set
        {
            if (value <= 0)
            {
                throw new Exception("StockQuantity shouldn't be lower than or equal to 0");
            }
            _stockQuantity = value;
        }
    }

    private readonly int _categoryId;
    private int CategoryId
    {
        get => _categoryId;
        init
        {
            if (value <= 0)
            {
                throw new Exception("CategoryId should be higher than zero.");
            }
            _categoryId = value;
        }
    }
}