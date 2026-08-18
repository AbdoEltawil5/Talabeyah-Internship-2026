using System.Collections;

namespace EShop.Console.Extensions;

public static class EnumerableExtension
{
    public static void CustomForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        IEnumerator<T> enumerator = source.GetEnumerator();

        try
        {
            while (enumerator.MoveNext())
            {
                action(enumerator.Current);
            }
        }
        finally
        {
            enumerator.Dispose();
        }
    }
}
