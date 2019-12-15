namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of downloading an object.
    /// </summary>
    public partial interface IDownloadAction : ITransferAction
    {
    }

    /// <summary>
    /// The act of downloading an object.
    /// </summary>
    [DataContract]
    public partial class DownloadAction : TransferAction, IDownloadAction, IEquatable<DownloadAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DownloadAction";

        /// <inheritdoc/>
        public bool Equals(DownloadAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as DownloadAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
