namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A table on a Web page.
    /// </summary>
    public partial interface ITable : IWebPageElement
    {
    }

    /// <summary>
    /// A table on a Web page.
    /// </summary>
    [DataContract]
    public partial class Table : WebPageElement, ITable, IEquatable<Table>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Table";
    }
}
