namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
    [DataContract]
    public partial class Permit : Intangible
    {
        public interface IIssuedBy : IValue {}
        public interface IIssuedBy<T> : IIssuedBy { new T Value { get; } }
        public class OneOrManyIssuedBy : OneOrMany<IIssuedBy>
        {
            public OneOrManyIssuedBy(IIssuedBy item) : base(item) { }
            public OneOrManyIssuedBy(IEnumerable<IIssuedBy> items) : base(items) { }
            public static implicit operator OneOrManyIssuedBy (Organization value) { return new OneOrManyIssuedBy (new IssuedByOrganization (value)); }
            public static implicit operator OneOrManyIssuedBy (Organization[] values) { return new OneOrManyIssuedBy (values.Select(v => (IIssuedBy) new IssuedByOrganization (v))); }
            public static implicit operator OneOrManyIssuedBy (List<Organization> values) { return new OneOrManyIssuedBy (values.Select(v => (IIssuedBy) new IssuedByOrganization (v))); }
        }
        public struct IssuedByOrganization : IIssuedBy<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public IssuedByOrganization (Organization value) { Value = value; }
            public static implicit operator IssuedByOrganization (Organization value) { return new IssuedByOrganization (value); }
        }

        public interface IIssuedThrough : IValue {}
        public interface IIssuedThrough<T> : IIssuedThrough { new T Value { get; } }
        public class OneOrManyIssuedThrough : OneOrMany<IIssuedThrough>
        {
            public OneOrManyIssuedThrough(IIssuedThrough item) : base(item) { }
            public OneOrManyIssuedThrough(IEnumerable<IIssuedThrough> items) : base(items) { }
            public static implicit operator OneOrManyIssuedThrough (Service value) { return new OneOrManyIssuedThrough (new IssuedThroughService (value)); }
            public static implicit operator OneOrManyIssuedThrough (Service[] values) { return new OneOrManyIssuedThrough (values.Select(v => (IIssuedThrough) new IssuedThroughService (v))); }
            public static implicit operator OneOrManyIssuedThrough (List<Service> values) { return new OneOrManyIssuedThrough (values.Select(v => (IIssuedThrough) new IssuedThroughService (v))); }
        }
        public struct IssuedThroughService : IIssuedThrough<Service>
        {
            object IValue.Value => this.Value;
            public Service Value { get; }
            public IssuedThroughService (Service value) { Value = value; }
            public static implicit operator IssuedThroughService (Service value) { return new IssuedThroughService (value); }
        }

        public interface IPermitAudience : IValue {}
        public interface IPermitAudience<T> : IPermitAudience { new T Value { get; } }
        public class OneOrManyPermitAudience : OneOrMany<IPermitAudience>
        {
            public OneOrManyPermitAudience(IPermitAudience item) : base(item) { }
            public OneOrManyPermitAudience(IEnumerable<IPermitAudience> items) : base(items) { }
            public static implicit operator OneOrManyPermitAudience (Audience value) { return new OneOrManyPermitAudience (new PermitAudienceAudience (value)); }
            public static implicit operator OneOrManyPermitAudience (Audience[] values) { return new OneOrManyPermitAudience (values.Select(v => (IPermitAudience) new PermitAudienceAudience (v))); }
            public static implicit operator OneOrManyPermitAudience (List<Audience> values) { return new OneOrManyPermitAudience (values.Select(v => (IPermitAudience) new PermitAudienceAudience (v))); }
        }
        public struct PermitAudienceAudience : IPermitAudience<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public PermitAudienceAudience (Audience value) { Value = value; }
            public static implicit operator PermitAudienceAudience (Audience value) { return new PermitAudienceAudience (value); }
        }

        public interface IValidFor : IValue {}
        public interface IValidFor<T> : IValidFor { new T Value { get; } }
        public class OneOrManyValidFor : OneOrMany<IValidFor>
        {
            public OneOrManyValidFor(IValidFor item) : base(item) { }
            public OneOrManyValidFor(IEnumerable<IValidFor> items) : base(items) { }
            public static implicit operator OneOrManyValidFor (TimeSpan value) { return new OneOrManyValidFor (new ValidForTimeSpan (value)); }
            public static implicit operator OneOrManyValidFor (TimeSpan[] values) { return new OneOrManyValidFor (values.Select(v => (IValidFor) new ValidForTimeSpan (v))); }
            public static implicit operator OneOrManyValidFor (List<TimeSpan> values) { return new OneOrManyValidFor (values.Select(v => (IValidFor) new ValidForTimeSpan (v))); }
        }
        public struct ValidForTimeSpan : IValidFor<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public ValidForTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator ValidForTimeSpan (TimeSpan value) { return new ValidForTimeSpan (value); }
        }

        public interface IValidFrom : IValue {}
        public interface IValidFrom<T> : IValidFrom { new T Value { get; } }
        public class OneOrManyValidFrom : OneOrMany<IValidFrom>
        {
            public OneOrManyValidFrom(IValidFrom item) : base(item) { }
            public OneOrManyValidFrom(IEnumerable<IValidFrom> items) : base(items) { }
            public static implicit operator OneOrManyValidFrom (DateTimeOffset value) { return new OneOrManyValidFrom (new ValidFromDateTimeOffset (value)); }
            public static implicit operator OneOrManyValidFrom (DateTimeOffset[] values) { return new OneOrManyValidFrom (values.Select(v => (IValidFrom) new ValidFromDateTimeOffset (v))); }
            public static implicit operator OneOrManyValidFrom (List<DateTimeOffset> values) { return new OneOrManyValidFrom (values.Select(v => (IValidFrom) new ValidFromDateTimeOffset (v))); }
        }
        public struct ValidFromDateTimeOffset : IValidFrom<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ValidFromDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ValidFromDateTimeOffset (DateTimeOffset value) { return new ValidFromDateTimeOffset (value); }
        }

        public interface IValidIn : IValue {}
        public interface IValidIn<T> : IValidIn { new T Value { get; } }
        public class OneOrManyValidIn : OneOrMany<IValidIn>
        {
            public OneOrManyValidIn(IValidIn item) : base(item) { }
            public OneOrManyValidIn(IEnumerable<IValidIn> items) : base(items) { }
            public static implicit operator OneOrManyValidIn (AdministrativeArea value) { return new OneOrManyValidIn (new ValidInAdministrativeArea (value)); }
            public static implicit operator OneOrManyValidIn (AdministrativeArea[] values) { return new OneOrManyValidIn (values.Select(v => (IValidIn) new ValidInAdministrativeArea (v))); }
            public static implicit operator OneOrManyValidIn (List<AdministrativeArea> values) { return new OneOrManyValidIn (values.Select(v => (IValidIn) new ValidInAdministrativeArea (v))); }
        }
        public struct ValidInAdministrativeArea : IValidIn<AdministrativeArea>
        {
            object IValue.Value => this.Value;
            public AdministrativeArea Value { get; }
            public ValidInAdministrativeArea (AdministrativeArea value) { Value = value; }
            public static implicit operator ValidInAdministrativeArea (AdministrativeArea value) { return new ValidInAdministrativeArea (value); }
        }

        public interface IValidUntil : IValue {}
        public interface IValidUntil<T> : IValidUntil { new T Value { get; } }
        public class OneOrManyValidUntil : OneOrMany<IValidUntil>
        {
            public OneOrManyValidUntil(IValidUntil item) : base(item) { }
            public OneOrManyValidUntil(IEnumerable<IValidUntil> items) : base(items) { }
            public static implicit operator OneOrManyValidUntil (DateTimeOffset value) { return new OneOrManyValidUntil (new ValidUntilDateTimeOffset (value)); }
            public static implicit operator OneOrManyValidUntil (DateTimeOffset[] values) { return new OneOrManyValidUntil (values.Select(v => (IValidUntil) new ValidUntilDateTimeOffset (v))); }
            public static implicit operator OneOrManyValidUntil (List<DateTimeOffset> values) { return new OneOrManyValidUntil (values.Select(v => (IValidUntil) new ValidUntilDateTimeOffset (v))); }
        }
        public struct ValidUntilDateTimeOffset : IValidUntil<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ValidUntilDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ValidUntilDateTimeOffset (DateTimeOffset value) { return new ValidUntilDateTimeOffset (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Permit";

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [DataMember(Name = "issuedBy", Order = 206)]
        public OneOrManyIssuedBy IssuedBy { get; set; }

        /// <summary>
        /// The service through with the permit was granted.
        /// </summary>
        [DataMember(Name = "issuedThrough", Order = 207)]
        public OneOrManyIssuedThrough IssuedThrough { get; set; }

        /// <summary>
        /// The target audience for this permit.
        /// </summary>
        [DataMember(Name = "permitAudience", Order = 208)]
        public OneOrManyPermitAudience PermitAudience { get; set; }

        /// <summary>
        /// The time validity of the permit.
        /// </summary>
        [DataMember(Name = "validFor", Order = 209)]
        public OneOrManyValidFor ValidFor { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 210)]
        public OneOrManyValidFrom ValidFrom { get; set; }

        /// <summary>
        /// The geographic area where the permit is valid.
        /// </summary>
        [DataMember(Name = "validIn", Order = 211)]
        public OneOrManyValidIn ValidIn { get; set; }

        /// <summary>
        /// The date when the item is no longer valid.
        /// </summary>
        [DataMember(Name = "validUntil", Order = 212)]
        public OneOrManyValidUntil ValidUntil { get; set; }
    }
}
