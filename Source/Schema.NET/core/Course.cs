namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
    [DataContract]
    public partial class Course : CreativeWork
    {
        public interface ICourseCode : IValue {}
        public interface ICourseCode<T> : ICourseCode { new T Value { get; } }
        public class OneOrManyCourseCode : OneOrMany<ICourseCode>
        {
            public OneOrManyCourseCode(ICourseCode item) : base(item) { }
            public OneOrManyCourseCode(IEnumerable<ICourseCode> items) : base(items) { }
            public static implicit operator OneOrManyCourseCode (string value) { return new OneOrManyCourseCode (new CourseCodestring (value)); }
            public static implicit operator OneOrManyCourseCode (string[] values) { return new OneOrManyCourseCode (values.Select(v => (ICourseCode) new CourseCodestring (v))); }
            public static implicit operator OneOrManyCourseCode (List<string> values) { return new OneOrManyCourseCode (values.Select(v => (ICourseCode) new CourseCodestring (v))); }
        }
        public struct CourseCodestring : ICourseCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CourseCodestring (string value) { Value = value; }
            public static implicit operator CourseCodestring (string value) { return new CourseCodestring (value); }
        }

        public interface ICoursePrerequisites : IValue {}
        public interface ICoursePrerequisites<T> : ICoursePrerequisites { new T Value { get; } }
        public class OneOrManyCoursePrerequisites : OneOrMany<ICoursePrerequisites>
        {
            public OneOrManyCoursePrerequisites(ICoursePrerequisites item) : base(item) { }
            public OneOrManyCoursePrerequisites(IEnumerable<ICoursePrerequisites> items) : base(items) { }
            public static implicit operator OneOrManyCoursePrerequisites (AlignmentObject value) { return new OneOrManyCoursePrerequisites (new CoursePrerequisitesAlignmentObject (value)); }
            public static implicit operator OneOrManyCoursePrerequisites (AlignmentObject[] values) { return new OneOrManyCoursePrerequisites (values.Select(v => (ICoursePrerequisites) new CoursePrerequisitesAlignmentObject (v))); }
            public static implicit operator OneOrManyCoursePrerequisites (List<AlignmentObject> values) { return new OneOrManyCoursePrerequisites (values.Select(v => (ICoursePrerequisites) new CoursePrerequisitesAlignmentObject (v))); }
            public static implicit operator OneOrManyCoursePrerequisites (Course value) { return new OneOrManyCoursePrerequisites (new CoursePrerequisitesCourse (value)); }
            public static implicit operator OneOrManyCoursePrerequisites (Course[] values) { return new OneOrManyCoursePrerequisites (values.Select(v => (ICoursePrerequisites) new CoursePrerequisitesCourse (v))); }
            public static implicit operator OneOrManyCoursePrerequisites (List<Course> values) { return new OneOrManyCoursePrerequisites (values.Select(v => (ICoursePrerequisites) new CoursePrerequisitesCourse (v))); }
            public static implicit operator OneOrManyCoursePrerequisites (string value) { return new OneOrManyCoursePrerequisites (new CoursePrerequisitesstring (value)); }
            public static implicit operator OneOrManyCoursePrerequisites (string[] values) { return new OneOrManyCoursePrerequisites (values.Select(v => (ICoursePrerequisites) new CoursePrerequisitesstring (v))); }
            public static implicit operator OneOrManyCoursePrerequisites (List<string> values) { return new OneOrManyCoursePrerequisites (values.Select(v => (ICoursePrerequisites) new CoursePrerequisitesstring (v))); }
        }
        public struct CoursePrerequisitesAlignmentObject : ICoursePrerequisites<AlignmentObject>
        {
            object IValue.Value => this.Value;
            public AlignmentObject Value { get; }
            public CoursePrerequisitesAlignmentObject (AlignmentObject value) { Value = value; }
            public static implicit operator CoursePrerequisitesAlignmentObject (AlignmentObject value) { return new CoursePrerequisitesAlignmentObject (value); }
        }
        public struct CoursePrerequisitesCourse : ICoursePrerequisites<Course>
        {
            object IValue.Value => this.Value;
            public Course Value { get; }
            public CoursePrerequisitesCourse (Course value) { Value = value; }
            public static implicit operator CoursePrerequisitesCourse (Course value) { return new CoursePrerequisitesCourse (value); }
        }
        public struct CoursePrerequisitesstring : ICoursePrerequisites<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CoursePrerequisitesstring (string value) { Value = value; }
            public static implicit operator CoursePrerequisitesstring (string value) { return new CoursePrerequisitesstring (value); }
        }

        public interface IEducationalCredentialAwarded : IValue {}
        public interface IEducationalCredentialAwarded<T> : IEducationalCredentialAwarded { new T Value { get; } }
        public class OneOrManyEducationalCredentialAwarded : OneOrMany<IEducationalCredentialAwarded>
        {
            public OneOrManyEducationalCredentialAwarded(IEducationalCredentialAwarded item) : base(item) { }
            public OneOrManyEducationalCredentialAwarded(IEnumerable<IEducationalCredentialAwarded> items) : base(items) { }
            public static implicit operator OneOrManyEducationalCredentialAwarded (string value) { return new OneOrManyEducationalCredentialAwarded (new EducationalCredentialAwardedstring (value)); }
            public static implicit operator OneOrManyEducationalCredentialAwarded (string[] values) { return new OneOrManyEducationalCredentialAwarded (values.Select(v => (IEducationalCredentialAwarded) new EducationalCredentialAwardedstring (v))); }
            public static implicit operator OneOrManyEducationalCredentialAwarded (List<string> values) { return new OneOrManyEducationalCredentialAwarded (values.Select(v => (IEducationalCredentialAwarded) new EducationalCredentialAwardedstring (v))); }
            public static implicit operator OneOrManyEducationalCredentialAwarded (Uri value) { return new OneOrManyEducationalCredentialAwarded (new EducationalCredentialAwardedUri (value)); }
            public static implicit operator OneOrManyEducationalCredentialAwarded (Uri[] values) { return new OneOrManyEducationalCredentialAwarded (values.Select(v => (IEducationalCredentialAwarded) new EducationalCredentialAwardedUri (v))); }
            public static implicit operator OneOrManyEducationalCredentialAwarded (List<Uri> values) { return new OneOrManyEducationalCredentialAwarded (values.Select(v => (IEducationalCredentialAwarded) new EducationalCredentialAwardedUri (v))); }
        }
        public struct EducationalCredentialAwardedstring : IEducationalCredentialAwarded<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EducationalCredentialAwardedstring (string value) { Value = value; }
            public static implicit operator EducationalCredentialAwardedstring (string value) { return new EducationalCredentialAwardedstring (value); }
        }
        public struct EducationalCredentialAwardedUri : IEducationalCredentialAwarded<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public EducationalCredentialAwardedUri (Uri value) { Value = value; }
            public static implicit operator EducationalCredentialAwardedUri (Uri value) { return new EducationalCredentialAwardedUri (value); }
        }

        public interface IHasCourseInstance : IValue {}
        public interface IHasCourseInstance<T> : IHasCourseInstance { new T Value { get; } }
        public class OneOrManyHasCourseInstance : OneOrMany<IHasCourseInstance>
        {
            public OneOrManyHasCourseInstance(IHasCourseInstance item) : base(item) { }
            public OneOrManyHasCourseInstance(IEnumerable<IHasCourseInstance> items) : base(items) { }
            public static implicit operator OneOrManyHasCourseInstance (CourseInstance value) { return new OneOrManyHasCourseInstance (new HasCourseInstanceCourseInstance (value)); }
            public static implicit operator OneOrManyHasCourseInstance (CourseInstance[] values) { return new OneOrManyHasCourseInstance (values.Select(v => (IHasCourseInstance) new HasCourseInstanceCourseInstance (v))); }
            public static implicit operator OneOrManyHasCourseInstance (List<CourseInstance> values) { return new OneOrManyHasCourseInstance (values.Select(v => (IHasCourseInstance) new HasCourseInstanceCourseInstance (v))); }
        }
        public struct HasCourseInstanceCourseInstance : IHasCourseInstance<CourseInstance>
        {
            object IValue.Value => this.Value;
            public CourseInstance Value { get; }
            public HasCourseInstanceCourseInstance (CourseInstance value) { Value = value; }
            public static implicit operator HasCourseInstanceCourseInstance (CourseInstance value) { return new HasCourseInstanceCourseInstance (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Course";

        /// <summary>
        /// The identifier for the &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; used by the course &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; (e.g. CS101 or 6.001).
        /// </summary>
        [DataMember(Name = "courseCode", Order = 206)]
        public OneOrManyCourseCode CourseCode { get; set; }

        /// <summary>
        /// Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "coursePrerequisites", Order = 207)]
        public OneOrManyCoursePrerequisites CoursePrerequisites { get; set; }

        /// <summary>
        /// A description of the qualification, award, certificate, diploma or other educational credential awarded as a consequence of successful completion of this course.
        /// </summary>
        [DataMember(Name = "educationalCredentialAwarded", Order = 208)]
        public OneOrManyEducationalCredentialAwarded EducationalCredentialAwarded { get; set; }

        /// <summary>
        /// An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.
        /// </summary>
        [DataMember(Name = "hasCourseInstance", Order = 209)]
        public OneOrManyHasCourseInstance HasCourseInstance { get; set; }
    }
}
