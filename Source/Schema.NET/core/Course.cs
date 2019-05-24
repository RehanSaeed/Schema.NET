namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
    public partial interface ICourse : ICreativeWork
    {
        /// <summary>
        /// The identifier for the &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; used by the course &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; (e.g. CS101 or 6.001).
        /// </summary>
        OneOrMany<string> CourseCode { get; set; }

        /// <summary>
        /// Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.
        /// </summary>
        Values<IAlignmentObject, ICourse, string>? CoursePrerequisites { get; set; }

        /// <summary>
        /// A description of the qualification, award, certificate, diploma or other educational credential awarded as a consequence of successful completion of this course.
        /// </summary>
        Values<string, Uri>? EducationalCredentialAwarded { get; set; }

        /// <summary>
        /// An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.
        /// </summary>
        OneOrMany<ICourseInstance> HasCourseInstance { get; set; }
    }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
    [DataContract]
    public partial class Course : CreativeWork, ICourse
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Course";

        /// <summary>
        /// The identifier for the &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; used by the course &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; (e.g. CS101 or 6.001).
        /// </summary>
        [DataMember(Name = "courseCode", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CourseCode { get; set; }

        /// <summary>
        /// Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "coursePrerequisites", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAlignmentObject, ICourse, string>? CoursePrerequisites { get; set; }

        /// <summary>
        /// A description of the qualification, award, certificate, diploma or other educational credential awarded as a consequence of successful completion of this course.
        /// </summary>
        [DataMember(Name = "educationalCredentialAwarded", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri>? EducationalCredentialAwarded { get; set; }

        /// <summary>
        /// An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.
        /// </summary>
        [DataMember(Name = "hasCourseInstance", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICourseInstance> HasCourseInstance { get; set; }
    }
}
