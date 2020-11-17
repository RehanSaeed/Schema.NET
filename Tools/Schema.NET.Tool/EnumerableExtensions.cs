namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Traverse<T>(T node, Func<T, T> parent)
        {
            if (parent is null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            for (var x = node; x is not null; x = parent(x))
            {
                yield return x;
            }
        }

        public static IEnumerable<T> Traverse<T>(T node, Func<T, IEnumerable<T>> children)
        {
            if (children is null)
            {
                throw new ArgumentNullException(nameof(children));
            }

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
