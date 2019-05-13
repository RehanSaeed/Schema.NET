namespace Schema.NET
{
    using System.Collections;

    /// <summary>
    /// An <see cref="IEnumerable"/> with a count.
    /// </summary>
#pragma warning disable CA1710 // Identifiers should have correct suffix
#pragma warning disable CA1010 // Collections should implement generic interface
    public interface IValues : IEnumerable
#pragma warning restore CA1010 // Collections should implement generic interface
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        int Count { get; }
    }
}
