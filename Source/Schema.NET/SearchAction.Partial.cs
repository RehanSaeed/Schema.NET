namespace Schema.NET
{
    using System.Runtime.Serialization;

    public partial class SearchAction
    {
        /// <summary>
        /// Gets or sets the query input search parameter.
        /// </summary>
        [DataMember(Name = "query-input", Order = 3)]
        public object QueryInput { get; set; }

        /// <summary>
        /// Gets or sets the query input search parameter.
        /// </summary>
        [IgnoreDataMember]
        public string QueryInputText
        {
            get => this.QueryInput as string;
            set => this.QueryInput = value;
        }

        /// <summary>
        /// Gets or sets the query input search parameter.
        /// </summary>
        [IgnoreDataMember]
        public PropertyValueSpecification QueryInputPropertyValueSpecification
        {
            get => this.QueryInput as PropertyValueSpecification;
            set => this.QueryInput = value;
        }
    }
}
