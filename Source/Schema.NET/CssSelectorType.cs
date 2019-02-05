namespace Schema.NET
{
    /// <summary>
    /// Defined by Google Structured Data in WebpageElement
    /// </summary>
    public struct CssSelectorType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CssSelectorType"/> struct.
        /// </summary>
        /// <param name="value">The value of CssSelectorType.</param>
        public CssSelectorType(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Retrieving the value
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Implicitly setting using a string
        /// </summary>
        /// <param name="item">The value of CssSelectorType.</param>
        public static implicit operator CssSelectorType(string item) => new CssSelectorType(item);
    }
}
