using System.Text;

namespace EShop.Console.Services;

public class OrderService : IOrderService
{
    private readonly IProductService _productService;
    public OrderService(IProductService productService)
    {
        _productService = productService;
    }
    public string GetOrderReceipt_String()
    {
        string receipt = string.Empty;
        receipt += "============= Order #123 =============\n\n";
        var products = _productService.GetProducts();
        decimal totalPrice = 0m;
        string currency = products.First().UnitPrice.Currency;
        foreach (var product in products)
        {
            receipt += $"{product}\n";
            totalPrice += product.StockQuantity * product.UnitPrice.Amount;
        }

        receipt += $"\nTotal Price: {totalPrice} {currency}";
        return receipt;
    }

    public string GetOrderReceipt_StringBuilder()
    {
        var receipt = new StringBuilder();
        receipt.Append("============= Order #123 =============\n\n");
        
        var products = _productService.GetProducts();
        decimal totalPrice = 0m;
        string currency = products.First().UnitPrice.Currency;
        foreach (var product in products)
        {
            receipt.Append($"{product}\n");
            totalPrice += product.StockQuantity * product.UnitPrice.Amount;
        }

        receipt.Append($"\nTotal Price: {totalPrice} {currency}");
        return receipt.ToString();
    }
}