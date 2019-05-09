namespace Schema.NET
{
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// Data type used to represent https://schema.org/Date
    /// </summary>
    public class IsoDate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsoDate"/> class.
        /// Constructor for date consisting of only year
        /// </summary>
        /// <param name="year">Year of date</param>
        public IsoDate(int year) => this.Year = year;

        /// <summary>
        /// Initializes a new instance of the <see cref="IsoDate"/> class.
        /// Constructor for date consisting of only year and month
        /// </summary>
        /// <param name="year">Year of date</param>
        /// <param name="month">Month of date</param>
        public IsoDate(int year, int month)
        : this(year) => this.Month = month;

        /// <summary>
        /// Initializes a new instance of the <see cref="IsoDate"/> class.
        /// Constructor for date consisting of year, month and day
        /// </summary>
        /// <param name="year">Year of date</param>
        /// <param name="month">Month of date</param>
        /// <param name="day">Day of date</param>
        public IsoDate(int year, int month, int day)
        : this(year, month) => this.Day = day;

        internal IsoDate(string dateString)
        {
            var valueSplit = dateString.Split('-').Select(v => int.Parse(v, CultureInfo.InvariantCulture)).ToList();
            if (valueSplit.Count >= 1)
            {
                this.Year = valueSplit[0];
            }

            if (valueSplit.Count >= 2)
            {
                this.Month = valueSplit[1];
            }

            if (valueSplit.Count == 3)
            {
                this.Day = valueSplit[2];
            }
        }

        /// <summary>
        /// Year of date
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Month of date
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// Day of date
        /// </summary>
        public int Day { get; set; }

        /// <summary>
        /// Returns ISO 8601 date string based on set values
        /// </summary>
        /// <returns>Formatted date string based on set values</returns>
        public override string ToString()
        {
            if (this.Year != 0 && this.Month != 0 && this.Day != 0)
            {
                return $"{this.Year}-{AddPadding(this.Month)}-{AddPadding(this.Day)}";
            }

            if (this.Year != 0 && this.Month != 0)
            {
                return $"{this.Year}-{AddPadding(this.Month)}";
            }

            return this.Year.ToString(CultureInfo.InvariantCulture);
        }

        private static string AddPadding(int value) => value < 10 ? $"0{value}" : value.ToString(CultureInfo.InvariantCulture);
    }
}
