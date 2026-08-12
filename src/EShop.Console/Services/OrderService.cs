using System.Text;
using EShop.Console.Entities;

namespace EShop.Console.Services;

public class OrderService
{
    public string GetOrderRecieptWithString(Order order)
    {
        string receipt = "";
        receipt += "Order Receipt";
        receipt += $" Order Id : {order.Id} \n";
        receipt += $"Status : {order.Status} \n";
        receipt += $"Created At : {order.CreatedAt} \n";
        receipt += $"Items: \n";
        
        foreach (var item in order.OrderItems)
        {
            receipt += " - " + item.Product.Name + " x " + item.Quantity
                       + " price " + item.Price
                       + " total " + item.LineTotal + "\n";
        }
        
        receipt += "Total: " + order.TotalAmount + "\n";
        return receipt;
    }

    public string GetOrderRecieptWithStringBuilder(Order order)
    {
        var sb = new StringBuilder();
        sb.AppendLine("Order Receipt");
        sb.AppendLine("Order Id :" + order.Id);
        sb.AppendLine("Status : " + order.Status);
        sb.AppendLine("Date: " + order.CreatedAt);
        sb.AppendLine("Items:");

        foreach (var item in order.OrderItems)
        {
            sb.AppendLine(" - " + item.Product.Name + " x " + item.Quantity
                          + " price " + item.Price
                          + " total " + item.LineTotal);
        }
        
        sb.AppendLine("Total: " + order.TotalAmount);
        return sb.ToString();
    }
}