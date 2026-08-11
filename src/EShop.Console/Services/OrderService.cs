using EShop.Console.Abstractions;
using EShop.Console.Entities;

namespace EShop.Console.Services;

public class OrderService(Notification notification, IAppDbContext appDbContext) : IOrderService
{
    private readonly Notification _notification = notification;
    private readonly IAppDbContext _appDbContext = appDbContext;

    public bool OrderProcessing(List<KeyValuePair<Product, int>> productsCount, double discountPercentage)
    {
        double orderTotal = 0;
        foreach (var productCount in productsCount)
        {
            if (productCount.Key.StockQuantity < productCount.Value)
            {
                System.Console.WriteLine($"Can't provide {productCount.Value} amount from {productCount.Key.Name} product. We have only {productCount.Key.StockQuantity}");
                return false;
            }

            productCount.Key.StockQuantity -= productCount.Value;
            orderTotal += productCount.Key.Price * productCount.Value;
        }

        orderTotal = appliedDiscountPercentage(orderTotal, discountPercentage);
        System.Console.WriteLine($"order Total is {orderTotal}");
        _appDbContext.SaveChanges();
        _notification.SendConfirmationMessage();

        return true;
    }
    private double appliedDiscountPercentage(double orderTotal, double percentage) => 
        orderTotal - (orderTotal * (percentage / 100));
}