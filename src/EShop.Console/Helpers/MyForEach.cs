using EShop.Console.Entities;

namespace EShop.Console.Helpers;

public static class MyForEach
{
    public static void MyForEachMethod<T>(this List<T> products, Action<T> action)
    {
        for (int i = 0; i < products.Count; i++)
        {
             action.Invoke(products[i]);
        }
    }
}