namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An instance of a &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
    [DataContract]
    public partial class CourseInstance : Event
    {
        public interface ICourseMode : IValue {}
        public interface ICourseMode<T> : ICourseMode { new T Value { get; } }
        public class OneOrManyCourseMode : OneOrMany<ICourseMode>
        {
            public OneOrManyCourseMode(ICourseMode item) : base(item) { }
            public OneOrManyCourseMode(IEnumerable<ICourseMode> items) : base(items) { }
            public static implicit operator OneOrManyCourseMode (string value) { return new OneOrManyCourseMode (new CourseModestring (value)); }
            public static implicit operator OneOrManyCourseMode (string[] values) { return new OneOrManyCourseMode (values.Select(v => (ICourseMode) new CourseModestring (v))); }
            public static implicit operator OneOrManyCourseMode (List<string> values) { return new OneOrManyCourseMode (values.Select(v => (ICourseMode) new CourseModestring (v))); }
            public static implicit operator OneOrManyCourseMode (Uri value) { return new OneOrManyCourseMode (new CourseModeUri (value)); }
            public static implicit operator OneOrManyCourseMode (Uri[] values) { return new OneOrManyCourseMode (values.Select(v => (ICourseMode) new CourseModeUri (v))); }
            public static implicit operator OneOrManyCourseMode (List<Uri> values) { return new OneOrManyCourseMode (values.Select(v => (ICourseMode) new CourseModeUri (v))); }
        }
        public struct CourseModestring : ICourseMode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CourseModestring (string value) { Value = value; }
            public static implicit operator CourseModestring (string value) { return new CourseModestring (value); }
        }
        public struct CourseModeUri : ICourseMode<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public CourseModeUri (Uri value) { Value = value; }
            public static implicit operator CourseModeUri (Uri value) { return new CourseModeUri (value); }
        }

        public interface IInstructor : IValue {}
        public interface IInstructor<T> : IInstructor { new T Value { get; } }
        public class OneOrManyInstructor : OneOrMany<IInstructor>
        {
            public OneOrManyInstructor(IInstructor item) : base(item) { }
            public OneOrManyInstructor(IEnumerable<IInstructor> items) : base(items) { }
            public static implicit operator OneOrManyInstructor (Person value) { return new OneOrManyInstructor (new InstructorPerson (value)); }
            public static implicit operator OneOrManyInstructor (Person[] values) { return new OneOrManyInstructor (values.Select(v => (IInstructor) new InstructorPerson (v))); }
            public static implicit operator OneOrManyInstructor (List<Person> values) { return new OneOrManyInstructor (values.Select(v => (IInstructor) new InstructorPerson (v))); }
        }
        public struct InstructorPerson : IInstructor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public InstructorPerson (Person value) { Value = value; }
            public static implicit operator InstructorPerson (Person value) { return new InstructorPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CourseInstance";

        /// <summary>
        /// The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).
        /// </summary>
        [DataMember(Name = "courseMode", Order = 206)]
        public OneOrManyCourseMode CourseMode { get; set; }

        /// <summary>
        /// A person assigned to instruct or provide instructional assistance for the &lt;a class="localLink" href="http://schema.org/CourseInstance"&gt;CourseInstance&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "instructor", Order = 207)]
        public OneOrManyInstructor Instructor { get; set; }
    }
}
