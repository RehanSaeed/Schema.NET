namespace Schema.NET
{
    /// <summary>
    /// Get a single value from one or more values.
    /// </summary>
    public interface IValue
    {
        /// <summary>
        /// Gets the non-null object representing the instance.
        /// </summary>
        object Value { get; }
    }
}
