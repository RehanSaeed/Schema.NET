namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.&lt;br/&gt;&lt;br/&gt;
    /// &lt;pre&gt;&lt;code&gt;  &amp;lt;br/&amp;gt;&amp;lt;br/&amp;gt;See also &amp;lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&amp;gt;blog post&amp;lt;/a&amp;gt;.
    /// &lt;/code&gt;&lt;/pre&gt;
    /// </summary>
    [DataContract]
    public partial class PublicationVolume : CreativeWork
    {
        public interface IPageEnd : IValue {}
        public interface IPageEnd<T> : IPageEnd { new T Value { get; } }
        public class OneOrManyPageEnd : OneOrMany<IPageEnd>
        {
            public OneOrManyPageEnd(IPageEnd item) : base(item) { }
            public OneOrManyPageEnd(IEnumerable<IPageEnd> items) : base(items) { }
            public static implicit operator OneOrManyPageEnd (int value) { return new OneOrManyPageEnd (new PageEndint (value)); }
            public static implicit operator OneOrManyPageEnd (int[] values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndint (v))); }
            public static implicit operator OneOrManyPageEnd (List<int> values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndint (v))); }
            public static implicit operator OneOrManyPageEnd (string value) { return new OneOrManyPageEnd (new PageEndstring (value)); }
            public static implicit operator OneOrManyPageEnd (string[] values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndstring (v))); }
            public static implicit operator OneOrManyPageEnd (List<string> values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndstring (v))); }
        }
        public struct PageEndint : IPageEnd<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public PageEndint (int value) { Value = value; }
            public static implicit operator PageEndint (int value) { return new PageEndint (value); }
        }
        public struct PageEndstring : IPageEnd<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PageEndstring (string value) { Value = value; }
            public static implicit operator PageEndstring (string value) { return new PageEndstring (value); }
        }

        public interface IPageStart : IValue {}
        public interface IPageStart<T> : IPageStart { new T Value { get; } }
        public class OneOrManyPageStart : OneOrMany<IPageStart>
        {
            public OneOrManyPageStart(IPageStart item) : base(item) { }
            public OneOrManyPageStart(IEnumerable<IPageStart> items) : base(items) { }
            public static implicit operator OneOrManyPageStart (int value) { return new OneOrManyPageStart (new PageStartint (value)); }
            public static implicit operator OneOrManyPageStart (int[] values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartint (v))); }
            public static implicit operator OneOrManyPageStart (List<int> values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartint (v))); }
            public static implicit operator OneOrManyPageStart (string value) { return new OneOrManyPageStart (new PageStartstring (value)); }
            public static implicit operator OneOrManyPageStart (string[] values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartstring (v))); }
            public static implicit operator OneOrManyPageStart (List<string> values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartstring (v))); }
        }
        public struct PageStartint : IPageStart<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public PageStartint (int value) { Value = value; }
            public static implicit operator PageStartint (int value) { return new PageStartint (value); }
        }
        public struct PageStartstring : IPageStart<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PageStartstring (string value) { Value = value; }
            public static implicit operator PageStartstring (string value) { return new PageStartstring (value); }
        }

        public interface IPagination : IValue {}
        public interface IPagination<T> : IPagination { new T Value { get; } }
        public class OneOrManyPagination : OneOrMany<IPagination>
        {
            public OneOrManyPagination(IPagination item) : base(item) { }
            public OneOrManyPagination(IEnumerable<IPagination> items) : base(items) { }
            public static implicit operator OneOrManyPagination (string value) { return new OneOrManyPagination (new Paginationstring (value)); }
            public static implicit operator OneOrManyPagination (string[] values) { return new OneOrManyPagination (values.Select(v => (IPagination) new Paginationstring (v))); }
            public static implicit operator OneOrManyPagination (List<string> values) { return new OneOrManyPagination (values.Select(v => (IPagination) new Paginationstring (v))); }
        }
        public struct Paginationstring : IPagination<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Paginationstring (string value) { Value = value; }
            public static implicit operator Paginationstring (string value) { return new Paginationstring (value); }
        }

        public interface IVolumeNumber : IValue {}
        public interface IVolumeNumber<T> : IVolumeNumber { new T Value { get; } }
        public class OneOrManyVolumeNumber : OneOrMany<IVolumeNumber>
        {
            public OneOrManyVolumeNumber(IVolumeNumber item) : base(item) { }
            public OneOrManyVolumeNumber(IEnumerable<IVolumeNumber> items) : base(items) { }
            public static implicit operator OneOrManyVolumeNumber (int value) { return new OneOrManyVolumeNumber (new VolumeNumberint (value)); }
            public static implicit operator OneOrManyVolumeNumber (int[] values) { return new OneOrManyVolumeNumber (values.Select(v => (IVolumeNumber) new VolumeNumberint (v))); }
            public static implicit operator OneOrManyVolumeNumber (List<int> values) { return new OneOrManyVolumeNumber (values.Select(v => (IVolumeNumber) new VolumeNumberint (v))); }
            public static implicit operator OneOrManyVolumeNumber (string value) { return new OneOrManyVolumeNumber (new VolumeNumberstring (value)); }
            public static implicit operator OneOrManyVolumeNumber (string[] values) { return new OneOrManyVolumeNumber (values.Select(v => (IVolumeNumber) new VolumeNumberstring (v))); }
            public static implicit operator OneOrManyVolumeNumber (List<string> values) { return new OneOrManyVolumeNumber (values.Select(v => (IVolumeNumber) new VolumeNumberstring (v))); }
        }
        public struct VolumeNumberint : IVolumeNumber<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public VolumeNumberint (int value) { Value = value; }
            public static implicit operator VolumeNumberint (int value) { return new VolumeNumberint (value); }
        }
        public struct VolumeNumberstring : IVolumeNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VolumeNumberstring (string value) { Value = value; }
            public static implicit operator VolumeNumberstring (string value) { return new VolumeNumberstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicationVolume";

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd", Order = 206)]
        public OneOrManyPageEnd PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart", Order = 207)]
        public OneOrManyPageStart PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination", Order = 208)]
        public OneOrManyPagination Pagination { get; set; }

        /// <summary>
        /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
        /// </summary>
        [DataMember(Name = "volumeNumber", Order = 209)]
        public OneOrManyVolumeNumber VolumeNumber { get; set; }
    }
}
