using System;

namespace DateCalculator.Lib
{
    public static class Calculator
    {
        public static DateSpan CalculateDifference(DateTime firstDate, DateTime secondDate)
        {
            var years = CalculateYears(firstDate, secondDate);
            var months = CalculateMonths(firstDate, secondDate, years);
            var days = CalculateDays(firstDate, secondDate, years, months);

            var result = new DateSpan
                             {
                                 Years = years,
                                 Months = months,
                                 Days = days
                             };

            return result;
        }

        public static DateTime GetModifiedDate(DateTime fromDate, DateFunction function, DateSpan dateOffset)
        {
            return function == DateFunction.Add ? AddToDate(fromDate, dateOffset) : SubtractFromDate(fromDate, dateOffset);
        }

        private static DateTime AddToDate(DateTime fromDate, DateSpan dateOffset)
        {
            return fromDate.AddYears(dateOffset.Years).AddMonths(dateOffset.Months).AddDays(dateOffset.Days);
        }

        private static DateTime SubtractFromDate(DateTime fromDate, DateSpan dateOffset)
        {
            return fromDate.AddDays(-dateOffset.Days).AddMonths(-dateOffset.Months).AddYears(-dateOffset.Years);
        }

        private static int CalculateDays(DateTime firstDate, DateTime secondDate, int years, int months)
        {
            return secondDate.Subtract(firstDate.AddYears(years).AddMonths(months)).Days;
        }

        private static int CalculateMonths(DateTime firstDate, DateTime secondDate, int years)
        {
            var result = 0;

            for (var i = 1; i <= 12; i++)
            {
                if (secondDate.Subtract(firstDate.AddYears(years).AddMonths(i)).Days >= 0)
                {
                    result = i;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        private static int CalculateYears(DateTime firstDate, DateTime secondDate)
        {
            if (secondDate.Month < firstDate.Month ||
                secondDate.Month == firstDate.Month &&
                secondDate.Day < firstDate.Day)
            {
                return ((secondDate.Year - firstDate.Year) - 1);
            }

            return (secondDate.Year - firstDate.Year);
        }
    }
}