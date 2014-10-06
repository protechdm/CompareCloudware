namespace CompareCloudware.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    internal static class IEnumerableForEachExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (T item in items)
            {
                action(item);
            }
        }

        public static void ForEachMatch<T>(this IEnumerable<T> items, Predicate<T> predicate, Action<T> action)
        {
            (from x in items
                where predicate(x)
                select x).ForEach<T>(action);
        }
    }
}

