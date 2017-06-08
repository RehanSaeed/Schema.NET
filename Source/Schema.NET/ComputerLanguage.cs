namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations...
    /// </summary>
    [DataContract]
    public class ComputerLanguage : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ComputerLanguage";
    }
}
