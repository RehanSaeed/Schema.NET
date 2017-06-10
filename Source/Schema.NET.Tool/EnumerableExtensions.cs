namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Traverse<T>(T node, Func<T, T> parent)
        {
            for (var x = node; x != null; x = parent(x))
            {
                yield return x;
            }
        }

        public static IEnumerable<T> Traverse<T>(T node, Func<T, IEnumerable<T>> children)
        {
            yield return node;

            var childNodes = children(node);
            if (childNodes != null)
            {
                foreach (var childNode in childNodes.SelectMany(x => Traverse(x, children)))
                {
                    yield return childNode;
                }
            }
        }
    }
}
