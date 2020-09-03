namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer.&lt;br/&gt;&lt;br/&gt;
    /// Originally, URLs from &lt;a href="http://purl.org/goodrelations/v1"&gt;GoodRelations&lt;/a&gt; were used (for &lt;a class="localLink" href="https://schema.org/Monday"&gt;Monday&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/Tuesday"&gt;Tuesday&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/Wednesday"&gt;Wednesday&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/Thursday"&gt;Thursday&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/Friday"&gt;Friday&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/Saturday"&gt;Saturday&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/Sunday"&gt;Sunday&lt;/a&gt; plus a special entry for &lt;a class="localLink" href="https://schema.org/PublicHolidays"&gt;PublicHolidays&lt;/a&gt;); these have now been integrated directly into schema.org.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DayOfWeek
    {
        /// <summary>
        /// The day of the week between Saturday and Monday.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Sunday")]
        Sunday,

        /// <summary>
        /// The day of the week between Sunday and Tuesday.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Monday")]
        Monday,

        /// <summary>
        /// The day of the week between Monday and Wednesday.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Tuesday")]
        Tuesday,

        /// <summary>
        /// The day of the week between Tuesday and Thursday.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Wednesday")]
        Wednesday,

        /// <summary>
        /// The day of the week between Wednesday and Friday.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Thursday")]
        Thursday,

        /// <summary>
        /// The day of the week between Thursday and Saturday.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Friday")]
        Friday,

        /// <summary>
        /// The day of the week between Friday and Sunday.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Saturday")]
        Saturday,

        /// <summary>
        /// This stands for any day that is a public holiday; it is a placeholder for all official public holidays in some particular location. While not technically a "day of the week", it can be used with &lt;a class="localLink" href="https://schema.org/OpeningHoursSpecification"&gt;OpeningHoursSpecification&lt;/a&gt;. In the context of an opening hours specification it can be used to indicate opening hours on public holidays, overriding general opening hours for the day of the week on which a public holiday occurs.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PublicHolidays")]
        PublicHolidays,
    }
}
