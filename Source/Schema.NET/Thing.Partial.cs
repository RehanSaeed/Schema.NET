namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;

    /// <summary>
    /// Base class for all objects within Schema.org
    /// </summary>
    public partial class Thing : JsonLdObject
    {
        private const string ContextPropertyJson = "\"@context\":\"http://schema.org\",";
        
        public Thing()
        {

        }

        public Thing(Uri url)
        {
            Url = url;
        }

        public static implicit operator Thing(Uri url) => new Thing(url);

        public Thing(string name)
        {
            Name = name;
        }

        public static implicit operator Thing(string name) => new Thing(name);      

        /// <summary>
        /// While parsing some site just place random items on a thing
        /// </summary>
        [DataMember(Name = "itemlist", Order = 9999999)]
        public OneOrMany<Thing> ItemList { get; set; }
    }
}
