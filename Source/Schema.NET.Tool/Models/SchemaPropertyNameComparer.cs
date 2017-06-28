namespace Schema.NET.Tool.Models
{
    using System.Collections.Generic;

    public class SchemaPropertyNameComparer : IComparer<string>
    {
        public static readonly Dictionary<string, int> KnownPropertyNameOrders = new Dictionary<string, int>
        {
            { "context", 0 },
            { "type", 1 },
            { "name", 2 },
            { "description", 3 }
        };

        public int Compare(string x, string y)
        {
            x = x.ToLower();
            y = y.ToLower();

            var isXKnown = KnownPropertyNameOrders.ContainsKey(x);
            var isYKnown = KnownPropertyNameOrders.ContainsKey(y);
            if (isXKnown && isYKnown)
            {
                var xIndex = KnownPropertyNameOrders[x];
                var yIndex = KnownPropertyNameOrders[y];
                return xIndex.CompareTo(yIndex);
            }
            else if(isXKnown)
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
