namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, or be offered through different media or modes of study...
    /// </summary>
    [DataContract]
    public class Course : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Course";

        /// <summary>
        /// The identifier for the &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; used by the course &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; (e.g. CS101 or 6.001).
        /// </summary>
        [DataMember(Name = "courseCode")]
        public string CourseCode { get; set; }

        /// <summary>
        /// Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "coursePrerequisites")]
        public object CoursePrerequisites { get; protected set; }

        /// <summary>
        /// Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Course CoursePrerequisitesCourse
        {
            get => this.CoursePrerequisites as Course;
            set => this.CoursePrerequisites = value;
        }

        /// <summary>
        /// Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public AlignmentObject CoursePrerequisitesAlignmentObject
        {
            get => this.CoursePrerequisites as AlignmentObject;
            set => this.CoursePrerequisites = value;
        }

        /// <summary>
        /// Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public string CoursePrerequisitesText
        {
            get => this.CoursePrerequisites as string;
            set => this.CoursePrerequisites = value;
        }

        /// <summary>
        /// An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.
        /// </summary>
        [DataMember(Name = "hasCourseInstance")]
        public CourseInstance HasCourseInstance { get; set; }
    }
}
