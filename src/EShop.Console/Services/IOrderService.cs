namespace EShop.Console.Services;

public interface IOrderService
{
    string GetOrderReceipt_String();
    string GetOrderReceipt_StringBuilder();
}