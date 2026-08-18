using System.Text;
using EShop.Console.Entities;

namespace EShop.Console.Services;

public interface IOrderReceiptService
{
    public string GetOrderReceiptstringV(Order order);
    public StringBuilder GetOrderReceiptstringBuilderV(Order order);
}