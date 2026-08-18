using EShop.Console.Entities;

namespace EShop.Console.Helpers;

public static class CartTotalPrice
{
    public static decimal TotalPrice(this Cart cart)
    {
        decimal totalPrice = 0;
        foreach (var cartItem in cart.Items)
        {
            totalPrice += (cartItem.Price * cartItem.Quantity);
        }
        return totalPrice;
    }
}