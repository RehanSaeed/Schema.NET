namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations. Natural languages are best represented with the &lt;a class="localLink" href="https://schema.org/Language"&gt;Language&lt;/a&gt; type.
    /// </summary>
    public partial interface IComputerLanguage : IIntangible
    {
    }

    /// <summary>
    /// This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations. Natural languages are best represented with the &lt;a class="localLink" href="https://schema.org/Language"&gt;Language&lt;/a&gt; type.
    /// </summary>
    [DataContract]
    public partial class ComputerLanguage : Intangible, IComputerLanguage, IEquatable<ComputerLanguage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComputerLanguage";

        /// <inheritdoc/>
        public bool Equals(ComputerLanguage other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ComputerLanguage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
