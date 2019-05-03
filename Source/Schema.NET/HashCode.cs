namespace Schema.NET
{
    using System.Collections.Generic;

    /// <summary>
    /// A hash code used to help with implementing <see cref="object.GetHashCode()"/>.
    /// </summary>
#pragma warning disable CA1815 // Override equals and operator equals on value types
    public struct HashCode
#pragma warning restore CA1815 // Override equals and operator equals on value types
    {
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="HashCode"/> struct.
        /// </summary>
        /// <param name="value">The value.</param>
        private HashCode(int value) => this.value = value;

        /// <summary>
        /// Performs an implicit conversion from <see cref="HashCode"/> to <see cref="int"/>.
        /// </summary>
        /// <param name="hashCode">The hash code.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator int(HashCode hashCode) => hashCode.value;
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Takes the hash code of the specified item.
        /// </summary>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <param name="item">The item.</param>
        /// <returns>The new hash code.</returns>
        public static HashCode Of<T>(T item) => new HashCode(GetHashCode(item));

        /// <summary>
        /// Takes the hash code of the specified items.
        /// </summary>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <param name="items">The collection.</param>
        /// <returns>The new hash code.</returns>
        public static HashCode OfEach<T>(IEnumerable<T> items) => new HashCode(GetHashCode(items, 0));

        /// <summary>
        /// Adds the hash code of the specified item.
        /// </summary>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <param name="item">The item.</param>
        /// <returns>The new hash code.</returns>
        public HashCode And<T>(T item) => new HashCode(CombineHashCodes(this.value, GetHashCode(item)));

        /// <summary>
        /// Adds the hash code of the specified items in the collection.
        /// </summary>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <param name="items">The collection.</param>
        /// <returns>The new hash code.</returns>
        public HashCode AndEach<T>(IEnumerable<T> items)
        {
            if (items == null)
            {
                return new HashCode(this.value);
            }

            return new HashCode(GetHashCode(items, this.value));
        }

        private static int CombineHashCodes(int h1, int h2)
        {
            unchecked
            {
                // Code copied from System.Tuple so it must be the best way to combine hash codes or at least a good one.
                return ((h1 << 5) + h1) ^ h2;
            }
        }

        private static int GetHashCode<T>(T item) => item == null ? 0 : item.GetHashCode();

        private static int GetHashCode<T>(IEnumerable<T> items, int startHashCode)
        {
            var temp = startHashCode;
            foreach (var item in items)
            {
                temp = CombineHashCodes(temp, GetHashCode(item));
            }

            return temp;
        }
    }
}
