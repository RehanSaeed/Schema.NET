namespace Schema.NET.Tool.Services
{
    using System;
    using System.Collections.Generic;

    public class EnumerationValueComparer : IComparer<string>
    {
        private static readonly Dictionary<string, int> KnownEnumerationValueOrders = new Dictionary<string, int>
        {
            { "SUNDAY", 0 },
            { "MONDAY", 1 },
            { "TUESDAY", 2 },
            { "WEDNESDAY", 3 },
            { "THURSDAY", 4 },
            { "FRIDAY", 5 },
            { "SATURDAY", 6 }
        };

        public int Compare(string x, string y)
        {
            if (x == null)
            {
                throw new ArgumentNullException(nameof(x));
            }

            if (y == null)
            {
                throw new ArgumentNullException(nameof(y));
            }

            x = x.ToUpperInvariant();
            y = y.ToUpperInvariant();

            var isXKnown = KnownEnumerationValueOrders.ContainsKey(x);
            var isYKnown = KnownEnumerationValueOrders.ContainsKey(y);
            if (isXKnown && isYKnown)
            {
                var xIndex = KnownEnumerationValueOrders[x];
                var yIndex = KnownEnumerationValueOrders[y];
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
