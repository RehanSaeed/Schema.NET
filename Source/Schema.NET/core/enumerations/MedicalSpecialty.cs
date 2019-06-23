namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Any specific branch of medical science or practice. Medical specialities include clinical specialties that pertain to particular organ systems and their respective disease states, as well as allied health specialties. Enumerated type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MedicalSpecialty
    {
        /// <summary>
        /// A specific branch of medical science that pertains to study of anesthetics and their application.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Anesthesia")]
        Anesthesia,

        /// <summary>
        /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of heart and vasculature.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Cardiovascular")]
        Cardiovascular,

        /// <summary>
        /// A field of public health focusing on improving health characteristics of a defined population in relation with their geographical or environment areas
        /// </summary>
        [EnumMember(Value = "http://schema.org/CommunityHealth")]
        CommunityHealth,

        /// <summary>
        /// A branch of medicine that is involved in the dental care.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Dentistry")]
        Dentistry,

        /// <summary>
        /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of skin.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Dermatology")]
        Dermatology,

        /// <summary>
        /// Dietetic and nutrition as a medical speciality.
        /// </summary>
        [EnumMember(Value = "http://schema.org/DietNutrition")]
        DietNutrition,

        /// <summary>
        /// A specific branch of medical science that deals with the evaluation and initial treatment of medical conditions caused by trauma or sudden illness.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Emergency")]
        Emergency,

        /// <summary>
        /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of endocrine glands and their secretions.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Endocrine")]
        Endocrine,

        /// <summary>
        /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of digestive system.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Gastroenterologic")]
        Gastroenterologic,

        /// <summary>
        /// A specific branch of medical science that pertains to hereditary transmission and the variation of inherited characteristics and disorders.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Genetic")]
        Genetic,

        /// <summary>
        /// A specific branch of medical science that is concerned with the diagnosis and treatment of diseases, debilities and provision of care to the aged.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Geriatric")]
        Geriatric,

        /// <summary>
        /// A specific branch of medical science that pertains to the health care of women, particularly in the diagnosis and treatment of disorders affecting the female reproductive system.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Gynecologic")]
        Gynecologic,

        /// <summary>
        /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of blood and blood producing organs.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Hematologic")]
        Hematologic,

        /// <summary>
        /// Something in medical science that pertains to infectious diseases i.e caused by bacterial, viral, fungal or parasitic infections.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Infectious")]
        Infectious,

        /// <summary>
        /// A medical science pertaining to chemical, hematological, immunologic, microscopic, or bacteriological diagnostic analyses or research
        /// </summary>
        [EnumMember(Value = "http://schema.org/LaboratoryScience")]
        LaboratoryScience,

        /// <summary>
        /// A nurse-like health profession that deals with pregnancy, childbirth, and the postpartum period (including care of the newborn), besides sexual and reproductive health of women throughout their lives.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Midwifery")]
        Midwifery,

        /// <summary>
        /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of muscles, ligaments and skeletal system.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Musculoskeletal")]
        Musculoskeletal,

        /// <summary>
        /// A specific branch of medical science that studies the nerves and nervous system and its respective disease states.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Neurologic")]
        Neurologic,

        /// <summary>
        /// A health profession of a person formally educated and trained in the care of the sick or infirm person.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Nursing")]
        Nursing,

        /// <summary>
        /// A specific branch of medical science that specializes in the care of women during the prenatal and postnatal care and with the delivery of the child.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Obstetric")]
        Obstetric,

        /// <summary>
        /// A specific branch of medical science that deals with benign and malignant tumors, including the study of their development, diagnosis, treatment and prevention.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Oncologic")]
        Oncologic,

        /// <summary>
        /// The science or practice of testing visual acuity and prescribing corrective lenses.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Optometric")]
        Optometric,

        /// <summary>
        /// A specific branch of medical science that is concerned with the ear, nose and throat and their respective disease states.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Otolaryngologic")]
        Otolaryngologic,

        /// <summary>
        /// A specific branch of medical science that is concerned with the study of the cause, origin and nature of a disease state, including its consequences as a result of manifestation of the disease. In clinical care, the term is used to designate a branch of medicine using laboratory tests to diagnose and determine the prognostic significance of illness.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Pathology")]
        Pathology,

        /// <summary>
        /// A specific branch of medical science that specializes in the care of infants, children and adolescents.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Pediatric")]
        Pediatric,

        /// <summary>
        /// The practice or art and science of preparing and dispensing drugs and medicines.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PharmacySpecialty")]
        PharmacySpecialty,

        /// <summary>
        /// The practice of treatment of disease, injury, or deformity by physical methods such as massage, heat treatment, and exercise rather than by drugs or surgery..
        /// </summary>
        [EnumMember(Value = "http://schema.org/Physiotherapy")]
        Physiotherapy,

        /// <summary>
        /// A specific branch of medical science that pertains to therapeutic or cosmetic repair or re-formation of missing, injured or malformed tissues or body parts by manual and instrumental means.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PlasticSurgery")]
        PlasticSurgery,

        /// <summary>
        /// Podiatry is the care of the human foot, especially the diagnosis and treatment of foot disorders.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Podiatric")]
        Podiatric,

        /// <summary>
        /// The medical care by a physician, or other health-care professional, who is the patient's first contact with the health-care system and who may recommend a specialist if necessary.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PrimaryCare")]
        PrimaryCare,

        /// <summary>
        /// A specific branch of medical science that is concerned with the study, treatment, and prevention of mental illness, using both medical and psychological therapies.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Psychiatric")]
        Psychiatric,

        /// <summary>
        /// Branch of medicine that pertains to the health services to improve and protect community health, especially epidemiology, sanitation, immunization, and preventive medicine.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PublicHealth")]
        PublicHealth,

        /// <summary>
        /// A specific branch of medical science that pertains to the study of the respiratory system and its respective disease states.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Pulmonary")]
        Pulmonary,

        /// <summary>
        /// Radiography is an imaging technique that uses electromagnetic radiation other than visible light, especially X-rays, to view the internal structure of a non-uniformly composed and opaque object such as the human body.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Radiography")]
        Radiography,

        /// <summary>
        /// A specific branch of medical science that pertains to the study of the kidneys and its respective disease states.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Renal")]
        Renal,

        /// <summary>
        /// The therapy that is concerned with the maintenance or improvement of respiratory function (as in patients with pulmonary disease).
        /// </summary>
        [EnumMember(Value = "http://schema.org/RespiratoryTherapy")]
        RespiratoryTherapy,

        /// <summary>
        /// A specific branch of medical science that deals with the study and treatment of rheumatic, autoimmune or joint diseases.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Rheumatologic")]
        Rheumatologic,

        /// <summary>
        /// The scientific study and treatment of defects, disorders, and malfunctions of speech and voice, as stuttering, lisping, or lalling, and of language disturbances, as aphasia or delayed language acquisition.
        /// </summary>
        [EnumMember(Value = "http://schema.org/SpeechPathology")]
        SpeechPathology,

        /// <summary>
        /// A specific branch of medical science that pertains to treating diseases, injuries and deformities by manual and instrumental means.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Surgical")]
        Surgical,

        /// <summary>
        /// A specific branch of medical science that is concerned with poisons, their nature, effects and detection and involved in the treatment of poisoning.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Toxicologic")]
        Toxicologic,

        /// <summary>
        /// A specific branch of medical science that is concerned with the diagnosis and treatment of diseases pertaining to the urinary tract and the urogenital system.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Urologic")]
        Urologic
    }
}
