namespace Schema.NET
{
    /// <summary>
    /// Defined by Google Structured Data in WebpageElement
    /// </summary>
    public struct XPathType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XPathType"/> struct.
        /// </summary>
        /// <param name="value">The value of XPathType.</param>
        public XPathType(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Retrieving the value
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Implicitly set the value using string
        /// </summary>
        /// <param name="item">The value of XPathType.</param>
        public static implicit operator XPathType(string item) => new XPathType(item);
    }
}
