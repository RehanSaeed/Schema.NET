namespace Schema.NET.Tool.Services
{
    using System;
    using System.Collections.Generic;

    public class PropertyNameComparer : IComparer<string>
    {
        public static readonly Dictionary<string, int> KnownPropertyNameOrders = new()
        {
            { "CONTEXT", 0 },
            { "TYPE", 1 },
            { "ID", 2 },
            { "TITLE", 3 },
            { "NAME", 4 },
            { "DESCRIPTION", 5 },
        };

        public int Compare(string? x, string? y)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(x);
            ArgumentNullException.ThrowIfNull(y);
#else
            if (x is null)
            {
                throw new ArgumentNullException(nameof(x));
            }

            if (y is null)
            {
                throw new ArgumentNullException(nameof(y));
            }
#endif

            if (x.Equals("ENDDATE", StringComparison.Ordinal))
            {
                x = "STARTDATE1";
            }
            else if (y.Equals("ENDDATE", StringComparison.Ordinal))
            {
                y = "STARTDATE1";
            }

            var isXKnown = KnownPropertyNameOrders.ContainsKey(x);
            var isYKnown = KnownPropertyNameOrders.ContainsKey(y);
            if (isXKnown && isYKnown)
            {
                var xIndex = KnownPropertyNameOrders[x];
                var yIndex = KnownPropertyNameOrders[y];
                return xIndex.CompareTo(yIndex);
            }
            else if (isXKnown)
            {
                return -1;
            }
            else if (isYKnown)
            {
                return 1;
            }

            return string.Compare(x, y, StringComparison.Ordinal);
        }
    }
}
