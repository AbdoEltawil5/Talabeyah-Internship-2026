using System.Text;
using EShop.Console.Entities;

namespace EShop.Console.Services;

public class OrderReceiptService : IOrderReceiptService
{
    public string GetOrderReceiptstringV(Order order)
    {
        string OrderReceipt = "";
        OrderReceipt += $"order id : {order.Id} \n";
        foreach (var orderItem in order.OrderItems)
        {
            OrderReceipt += $"orderItem id : {orderItem.Id}, orderItem Price : {orderItem.Price}, orderItem Name : {orderItem.Product.Name} \n";
        }

        OrderReceipt += $"{order.TotalAmount.getAmount() + "   "+order.TotalAmount.getCurrency()} \n";
        return OrderReceipt;
    }

    public StringBuilder GetOrderReceiptstringBuilderV(Order order)
    {
        StringBuilder OrderReceipt = new StringBuilder("");
        OrderReceipt.Append($"order id : {order.Id} \n");
        foreach (var orderItem in order.OrderItems)
        {
            OrderReceipt.Append($"orderItem id : {orderItem.Id}, orderItem Price : {orderItem.Price}, orderItem Name : {orderItem.Product.Name} \n");
        }

        OrderReceipt.Append($"{order.TotalAmount.getAmount() + "   "+order.TotalAmount.getCurrency()} \n");
        return OrderReceipt;
    }
}