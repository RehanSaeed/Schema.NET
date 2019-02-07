namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes.
    /// </summary>
    [DataContract]
    public partial class ImagingTest : MedicalTest
    {
        public interface IImagingTechnique : IValue {}
        public interface IImagingTechnique<T> : IImagingTechnique { new T Value { get; } }
        public class OneOrManyImagingTechnique : OneOrMany<IImagingTechnique>
        {
            public OneOrManyImagingTechnique(IImagingTechnique item) : base(item) { }
            public OneOrManyImagingTechnique(IEnumerable<IImagingTechnique> items) : base(items) { }
            public static implicit operator OneOrManyImagingTechnique (MedicalImagingTechnique value) { return new OneOrManyImagingTechnique (new ImagingTechniqueMedicalImagingTechnique (value)); }
            public static implicit operator OneOrManyImagingTechnique (MedicalImagingTechnique[] values) { return new OneOrManyImagingTechnique (values.Select(v => (IImagingTechnique) new ImagingTechniqueMedicalImagingTechnique (v))); }
            public static implicit operator OneOrManyImagingTechnique (List<MedicalImagingTechnique> values) { return new OneOrManyImagingTechnique (values.Select(v => (IImagingTechnique) new ImagingTechniqueMedicalImagingTechnique (v))); }
        }
        public struct ImagingTechniqueMedicalImagingTechnique : IImagingTechnique<MedicalImagingTechnique>
        {
            object IValue.Value => this.Value;
            public MedicalImagingTechnique Value { get; }
            public ImagingTechniqueMedicalImagingTechnique (MedicalImagingTechnique value) { Value = value; }
            public static implicit operator ImagingTechniqueMedicalImagingTechnique (MedicalImagingTechnique value) { return new ImagingTechniqueMedicalImagingTechnique (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ImagingTest";

        /// <summary>
        /// Imaging technique used.
        /// </summary>
        [DataMember(Name = "imagingTechnique", Order = 306)]
        public OneOrManyImagingTechnique ImagingTechnique { get; set; }
    }
}
