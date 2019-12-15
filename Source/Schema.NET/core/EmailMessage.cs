namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An email message.
    /// </summary>
    public partial interface IEmailMessage : IMessage
    {
    }

    /// <summary>
    /// An email message.
    /// </summary>
    [DataContract]
    public partial class EmailMessage : Message, IEmailMessage, IEquatable<EmailMessage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmailMessage";

        /// <inheritdoc/>
        public bool Equals(EmailMessage other)
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
        public override bool Equals(object obj) => this.Equals(obj as EmailMessage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
