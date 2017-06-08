namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered...
    /// </summary>
    [DataContract]
    public class PublicationVolume : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PublicationVolume";

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination")]
        public string Pagination { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd")]
        public object PageEnd { get; protected set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [IgnoreDataMember]
        public string PageEndText
        {
            get => this.PageEnd as string;
            set => this.PageEnd = value;
        }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [IgnoreDataMember]
        public int? PageEndInteger
        {
            get => this.PageEnd as int?;
            set => this.PageEnd = value;
        }

        /// <summary>
        /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
        /// </summary>
        [DataMember(Name = "volumeNumber")]
        public object VolumeNumber { get; protected set; }

        /// <summary>
        /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
        /// </summary>
        [IgnoreDataMember]
        public string VolumeNumberText
        {
            get => this.VolumeNumber as string;
            set => this.VolumeNumber = value;
        }

        /// <summary>
        /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
        /// </summary>
        [IgnoreDataMember]
        public int? VolumeNumberInteger
        {
            get => this.VolumeNumber as int?;
            set => this.VolumeNumber = value;
        }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart")]
        public object PageStart { get; protected set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [IgnoreDataMember]
        public int? PageStartInteger
        {
            get => this.PageStart as int?;
            set => this.PageStart = value;
        }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [IgnoreDataMember]
        public string PageStartText
        {
            get => this.PageStart as string;
            set => this.PageStart = value;
        }
    }
}
