namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;

    public static class CollectionExtensions
    {
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(collection);
            ArgumentNullException.ThrowIfNull(items);
#else
            if (collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (items is null)
            {
                throw new ArgumentNullException(nameof(items));
            }
#endif

            foreach (var item in items)
            {
                collection.Add(item);
            }
        }
    }
}
