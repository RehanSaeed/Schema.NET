﻿namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// An enumeration that describes different types of medical procedures.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MedicalProcedureType
    {
        /// <summary>
        /// A type of medical procedure that involves noninvasive techniques.
        /// </summary>
        [EnumMember(Value = "https://schema.org/NoninvasiveProcedure")]
        NoninvasiveProcedure,

        /// <summary>
        /// A type of medical procedure that involves percutaneous techniques, where access to organs or tissue is achieved via needle-puncture of the skin. For example, catheter-based procedures like stent delivery.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PercutaneousProcedure")]
        PercutaneousProcedure
    }
}
