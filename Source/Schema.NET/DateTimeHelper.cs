namespace Schema.NET
{
    using System;

    /// <summary>
    /// Helper for parsing strings into <see cref="DateTime"/> or <see cref="DateTimeOffset"/>
    /// </summary>
    internal static class DateTimeHelper
    {
        private const string MSDateStringStart = "/Date(";
        private const string MSDateStringEnd = ")/";
        private const string NegativeOffset = "-";
        private static readonly DateTime EpochDate = new DateTime(1970, 1, 1);
        private static readonly char[] OffsetChars = new[] { '+', '-' };

        /// <summary>
        /// Whether a given ISO 8601 date string has an offset defined (eg. "+", "-", "Z")
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns>True if the input string has an offset defined</returns>
        public static bool ContainsTimeOffset(string input)
        {
            if (input.IndexOf("+", StringComparison.Ordinal) != -1 || input.IndexOf("Z", StringComparison.Ordinal) != -1)
            {
                return true;
            }

            var timeSeparatorIndex = input.IndexOf("T", StringComparison.Ordinal);
            if (timeSeparatorIndex != -1)
            {
                return input.IndexOf(NegativeOffset, timeSeparatorIndex, StringComparison.Ordinal) != -1;
            }

            return false;
        }

        /// <summary>
        /// Parse MS DateTime as Date eg. "/Date(946730040000)/"
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="result">The result date and time</param>
        /// <returns>True if the input string was able to be parsed into a <see cref="DateTime"/></returns>
        public static bool TryParseMSDateTime(string input, out DateTime result)
        {
            if (input.StartsWith(MSDateStringStart, StringComparison.Ordinal) && input.EndsWith(MSDateStringEnd, StringComparison.Ordinal))
            {
                var dateTimeStartIndex = MSDateStringStart.Length;
                var dateTimeLength = input.IndexOf(MSDateStringEnd, StringComparison.Ordinal) - dateTimeStartIndex;

#if NETCOREAPP3_1
                var timeValue = input.AsSpan().Slice(dateTimeStartIndex, dateTimeLength);
#else
                var timeValue = input.Substring(dateTimeStartIndex, dateTimeLength);
#endif

                if (double.TryParse(timeValue, out var milliseconds))
                {
                    result = EpochDate.AddMilliseconds(milliseconds);
                    return true;
                }
            }

            result = DateTime.MinValue;
            return false;
        }

        /// <summary>
        /// Parse MS DateTime as <see cref="DateTimeOffset"/> eg. "/Date(946730040000-0100)/"
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="result">The result date and time with offset</param>
        /// <returns>True if the input string was able to be parsed into a <see cref="DateTimeOffset"/></returns>
        public static bool TryParseMSDateTimeOffset(string input, out DateTimeOffset result)
        {
            if (input.StartsWith(MSDateStringStart, StringComparison.Ordinal) && input.EndsWith(MSDateStringEnd, StringComparison.Ordinal))
            {
                var dateTimeStartIndex = MSDateStringStart.Length;
                var offsetIndex = input.IndexOfAny(OffsetChars);
                var dateTimeLength = offsetIndex - dateTimeStartIndex;
                var offsetLength = input.IndexOf(MSDateStringEnd, offsetIndex, StringComparison.Ordinal) - offsetIndex;

#if NETCOREAPP3_1
                var timeValue = input.AsSpan().Slice(dateTimeStartIndex, dateTimeLength);
                var offsetType = input.AsSpan().Slice(offsetIndex, 1);
                var offsetValue = input.AsSpan().Slice(offsetIndex + 1, offsetLength - 1);
#else
                var timeValue = input.Substring(dateTimeStartIndex, dateTimeLength);
                var offsetType = input.Substring(offsetIndex, 1);
                var offsetValue = input.Substring(offsetIndex + 1, offsetLength);
#endif

                if (double.TryParse(timeValue, out var milliseconds))
                {
                    if (int.TryParse(offsetValue, out var offset))
                    {
                        var dateTime = EpochDate.AddMilliseconds(milliseconds);
                        var hours = offset / 100;
                        var minutes = offset - (hours * 100);
                        var offsetTimeSpan = new TimeSpan(hours, minutes, 0);

                        if (offsetType[0] == NegativeOffset[0])
                        {
                            offsetTimeSpan = -offsetTimeSpan;
                        }

                        result = new DateTimeOffset(dateTime, offsetTimeSpan);
                        return true;
                    }
                }
            }

            result = DateTimeOffset.MinValue;
            return false;
        }
    }
}
