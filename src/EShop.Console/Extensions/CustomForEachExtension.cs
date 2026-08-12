namespace EShop.Console.Extensions;

public static class CustomForEachExtension
{
    public static void CustomForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
    {
        using var enumerator = enumerable.GetEnumerator();
        while (enumerator.MoveNext())
        {
            T item = enumerator.Current;
            action.Invoke(item);
        }
    }
}