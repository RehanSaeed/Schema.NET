namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of finding an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SearchAction"&gt;SearchAction&lt;/a&gt;: FindAction is generally lead by a SearchAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IFindAction : IAction
    {
    }

    /// <summary>
    /// The act of finding an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SearchAction"&gt;SearchAction&lt;/a&gt;: FindAction is generally lead by a SearchAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class FindAction : Action, IFindAction, IEquatable<FindAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FindAction";
    }
}
