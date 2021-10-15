namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Traverse<T>(T node, Func<T, T> parent)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(parent);
#else
            if (parent is null)
            {
                throw new ArgumentNullException(nameof(parent));
            }
#endif

            for (var x = node; x is not null; x = parent(x))
            {
                yield return x;
            }
        }

        public static IEnumerable<T> Traverse<T>(T node, Func<T, IEnumerable<T>> children)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(children);
#else
            if (children is null)
            {
                throw new ArgumentNullException(nameof(children));
            }
#endif

            yield return node;

            var childNodes = children(node);
            if (childNodes is not null)
            {
                foreach (var childNode in childNodes.SelectMany(x => Traverse(x, children)))
                {
                    yield return childNode;
                }
            }
        }
    }
}
