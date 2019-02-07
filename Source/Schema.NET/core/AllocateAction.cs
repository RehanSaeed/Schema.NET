namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    [DataContract]
    public partial class AllocateAction : OrganizeAction
    {
        public interface IPurpose : IValue {}
        public interface IPurpose<T> : IPurpose { new T Value { get; } }
        public class OneOrManyPurpose : OneOrMany<IPurpose>
        {
            public OneOrManyPurpose(IPurpose item) : base(item) { }
            public OneOrManyPurpose(IEnumerable<IPurpose> items) : base(items) { }
            public static implicit operator OneOrManyPurpose (MedicalDevicePurpose value) { return new OneOrManyPurpose (new PurposeMedicalDevicePurpose (value)); }
            public static implicit operator OneOrManyPurpose (MedicalDevicePurpose[] values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeMedicalDevicePurpose (v))); }
            public static implicit operator OneOrManyPurpose (List<MedicalDevicePurpose> values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeMedicalDevicePurpose (v))); }
            public static implicit operator OneOrManyPurpose (Thing value) { return new OneOrManyPurpose (new PurposeThing (value)); }
            public static implicit operator OneOrManyPurpose (Thing[] values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeThing (v))); }
            public static implicit operator OneOrManyPurpose (List<Thing> values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeThing (v))); }
        }
        public struct PurposeMedicalDevicePurpose : IPurpose<MedicalDevicePurpose>
        {
            object IValue.Value => this.Value;
            public MedicalDevicePurpose Value { get; }
            public PurposeMedicalDevicePurpose (MedicalDevicePurpose value) { Value = value; }
            public static implicit operator PurposeMedicalDevicePurpose (MedicalDevicePurpose value) { return new PurposeMedicalDevicePurpose (value); }
        }
        public struct PurposeThing : IPurpose<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public PurposeThing (Thing value) { Value = value; }
            public static implicit operator PurposeThing (Thing value) { return new PurposeThing (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AllocateAction";

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [DataMember(Name = "purpose", Order = 306)]
        public OneOrManyPurpose Purpose { get; set; }
    }
}
