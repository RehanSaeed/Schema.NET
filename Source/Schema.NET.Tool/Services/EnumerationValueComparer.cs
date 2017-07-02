namespace Schema.NET.Tool.Services
{
    using System.Collections.Generic;

    public class EnumerationValueComparer : IComparer<string>
    {
        public static readonly Dictionary<string, int> KnownEnumerationValueOrders = new Dictionary<string, int>
        {
            { "sunday", 0 },
            { "monday", 1 },
            { "tuesday", 2 },
            { "wednesday", 3 },
            { "thursday", 4 },
            { "friday", 5 },
            { "saturday", 6 }
        };

        public int Compare(string x, string y)
        {
            x = x.ToLower();
            y = y.ToLower();

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

            return x.CompareTo(y);
        }
    }
}
