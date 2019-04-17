using System;

namespace Sixeyed.Extensions.Samples.Demo1
{
    public static class LegacyExtensions
    {
        public static string ToLegacyFormat(this DateTime datetime)
        {
            return datetime.Year > 1930 ? datetime.ToString("1yyMMdd") : datetime.ToString("0yyMMdd");
        }

        public static string ToLegacyFormat(this string fullName)
        {
            var parts = fullName.ToUpper().Split(' ');
            return parts[1] + ", " + parts[0];
        }
    }
}
