namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
    [DataContract]
    public class ChooseAction : AssessAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ChooseAction";

        /// <summary>
        /// A sub property of object. The options subject to this action.
        /// </summary>
        [DataMember(Name = "actionOption", Order = 2)]
        public object ActionOption { get; protected set; }

        /// <summary>
        /// A sub property of object. The options subject to this action.
        /// </summary>
        [IgnoreDataMember]
        public string ActionOptionText
        {
            get => this.ActionOption as string;
            set => this.ActionOption = value;
        }

        /// <summary>
        /// A sub property of object. The options subject to this action.
        /// </summary>
        [IgnoreDataMember]
        public Thing ActionOptionThing
        {
            get => this.ActionOption as Thing;
            set => this.ActionOption = value;
        }
    }
}
