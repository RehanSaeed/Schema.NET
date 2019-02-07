namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/06/introducing-role.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Role : Intangible
    {
        public interface IRoleName : IValue {}
        public interface IRoleName<T> : IRoleName { new T Value { get; } }
        public class OneOrManyRoleName : OneOrMany<IRoleName>
        {
            public OneOrManyRoleName(IRoleName item) : base(item) { }
            public OneOrManyRoleName(IEnumerable<IRoleName> items) : base(items) { }
            public static implicit operator OneOrManyRoleName (string value) { return new OneOrManyRoleName (new RoleNamestring (value)); }
            public static implicit operator OneOrManyRoleName (string[] values) { return new OneOrManyRoleName (values.Select(v => (IRoleName) new RoleNamestring (v))); }
            public static implicit operator OneOrManyRoleName (List<string> values) { return new OneOrManyRoleName (values.Select(v => (IRoleName) new RoleNamestring (v))); }
            public static implicit operator OneOrManyRoleName (Uri value) { return new OneOrManyRoleName (new RoleNameUri (value)); }
            public static implicit operator OneOrManyRoleName (Uri[] values) { return new OneOrManyRoleName (values.Select(v => (IRoleName) new RoleNameUri (v))); }
            public static implicit operator OneOrManyRoleName (List<Uri> values) { return new OneOrManyRoleName (values.Select(v => (IRoleName) new RoleNameUri (v))); }
        }
        public struct RoleNamestring : IRoleName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RoleNamestring (string value) { Value = value; }
            public static implicit operator RoleNamestring (string value) { return new RoleNamestring (value); }
        }
        public struct RoleNameUri : IRoleName<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public RoleNameUri (Uri value) { Value = value; }
            public static implicit operator RoleNameUri (Uri value) { return new RoleNameUri (value); }
        }

        public interface IStartDate : IValue {}
        public interface IStartDate<T> : IStartDate { new T Value { get; } }
        public class OneOrManyStartDate : OneOrMany<IStartDate>
        {
            public OneOrManyStartDate(IStartDate item) : base(item) { }
            public OneOrManyStartDate(IEnumerable<IStartDate> items) : base(items) { }
            public static implicit operator OneOrManyStartDate (DateTimeOffset value) { return new OneOrManyStartDate (new StartDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyStartDate (DateTimeOffset[] values) { return new OneOrManyStartDate (values.Select(v => (IStartDate) new StartDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyStartDate (List<DateTimeOffset> values) { return new OneOrManyStartDate (values.Select(v => (IStartDate) new StartDateDateTimeOffset (v))); }
        }
        public struct StartDateDateTimeOffset : IStartDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public StartDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator StartDateDateTimeOffset (DateTimeOffset value) { return new StartDateDateTimeOffset (value); }
        }

        public interface IEndDate : IValue {}
        public interface IEndDate<T> : IEndDate { new T Value { get; } }
        public class OneOrManyEndDate : OneOrMany<IEndDate>
        {
            public OneOrManyEndDate(IEndDate item) : base(item) { }
            public OneOrManyEndDate(IEnumerable<IEndDate> items) : base(items) { }
            public static implicit operator OneOrManyEndDate (DateTimeOffset value) { return new OneOrManyEndDate (new EndDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyEndDate (DateTimeOffset[] values) { return new OneOrManyEndDate (values.Select(v => (IEndDate) new EndDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyEndDate (List<DateTimeOffset> values) { return new OneOrManyEndDate (values.Select(v => (IEndDate) new EndDateDateTimeOffset (v))); }
        }
        public struct EndDateDateTimeOffset : IEndDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public EndDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator EndDateDateTimeOffset (DateTimeOffset value) { return new EndDateDateTimeOffset (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Role";

        /// <summary>
        /// A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.
        /// </summary>
        [DataMember(Name = "roleName", Order = 206)]
        public OneOrManyRoleName RoleName { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 207)]
        public OneOrManyStartDate StartDate { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 208)]
        public OneOrManyEndDate EndDate { get; set; }
    }
}
