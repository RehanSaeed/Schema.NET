using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
    [DataContract]
    public partial class Course : CreativeWork
    {
        public interface ICoursePrerequisites : IWrapper { }
        public interface ICoursePrerequisites<T> : ICoursePrerequisites { new T Data { get; set; } }
        public class CoursePrerequisitesAlignmentObject : ICoursePrerequisites<AlignmentObject>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AlignmentObject) value; } }
            public virtual AlignmentObject Data { get; set; }
            public CoursePrerequisitesAlignmentObject () { }
            public CoursePrerequisitesAlignmentObject (AlignmentObject data) { Data = data; }
            public static implicit operator CoursePrerequisitesAlignmentObject (AlignmentObject data) { return new CoursePrerequisitesAlignmentObject (data); }
        }

        public class CoursePrerequisitesCourse : ICoursePrerequisites<Course>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Course) value; } }
            public virtual Course Data { get; set; }
            public CoursePrerequisitesCourse () { }
            public CoursePrerequisitesCourse (Course data) { Data = data; }
            public static implicit operator CoursePrerequisitesCourse (Course data) { return new CoursePrerequisitesCourse (data); }
        }

        public class CoursePrerequisitesstring : ICoursePrerequisites<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public CoursePrerequisitesstring () { }
            public CoursePrerequisitesstring (string data) { Data = data; }
            public static implicit operator CoursePrerequisitesstring (string data) { return new CoursePrerequisitesstring (data); }
        }


        public interface IEducationalCredentialAwarded : IWrapper { }
        public interface IEducationalCredentialAwarded<T> : IEducationalCredentialAwarded { new T Data { get; set; } }
        public class EducationalCredentialAwardedstring : IEducationalCredentialAwarded<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public EducationalCredentialAwardedstring () { }
            public EducationalCredentialAwardedstring (string data) { Data = data; }
            public static implicit operator EducationalCredentialAwardedstring (string data) { return new EducationalCredentialAwardedstring (data); }
        }

        public class EducationalCredentialAwardedUri : IEducationalCredentialAwarded<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public EducationalCredentialAwardedUri () { }
            public EducationalCredentialAwardedUri (Uri data) { Data = data; }
            public static implicit operator EducationalCredentialAwardedUri (Uri data) { return new EducationalCredentialAwardedUri (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? CourseCode { get; set; } 

        /// <summary>
        /// Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "coursePrerequisites", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICoursePrerequisites>? CoursePrerequisites { get; set; } //AlignmentObject, Course, string

        /// <summary>
        /// A description of the qualification, award, certificate, diploma or other educational credential awarded as a consequence of successful completion of this course.
        /// </summary>
        [DataMember(Name = "educationalCredentialAwarded", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IEducationalCredentialAwarded>? EducationalCredentialAwarded { get; set; } //string, Uri

        /// <summary>
        /// An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.
        /// </summary>
        [DataMember(Name = "hasCourseInstance", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CourseInstance>? HasCourseInstance { get; set; } 
    }
}
