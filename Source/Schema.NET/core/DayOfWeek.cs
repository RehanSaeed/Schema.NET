namespace Schema.NET
{
    /// <summary>
    /// The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer...
    /// </summary>
    public enum DayOfWeek
    {
        /// <summary>
        /// The day of the week between Thursday and Saturday.
        /// </summary>
        Friday,

        /// <summary>
        /// The day of the week between Sunday and Tuesday.
        /// </summary>
        Monday,

        /// <summary>
        /// This stands for any day that is a public holiday; it is a placeholder for all official public holidays in some particular location. While not technically a "day of the week", it can be used with &lt;a class="localLink" href="http://schema.org/OpeningHoursSpecification"&gt;OpeningHoursSpecification&lt;/a&gt;. In the context of an opening hours specification it can be used to indicate opening hours on public holidays, overriding general opening hours for the day of the week on which a public holiday occurs.
        /// </summary>
        PublicHolidays,

        /// <summary>
        /// The day of the week between Friday and Sunday.
        /// </summary>
        Saturday,

        /// <summary>
        /// The day of the week between Saturday and Monday.
        /// </summary>
        Sunday,

        /// <summary>
        /// The day of the week between Wednesday and Friday.
        /// </summary>
        Thursday,

        /// <summary>
        /// The day of the week between Monday and Wednesday.
        /// </summary>
        Tuesday,

        /// <summary>
        /// The day of the week between Tuesday and Thursday.
        /// </summary>
        Wednesday
    }
}
