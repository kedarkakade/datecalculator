using System;
using DateCalculator.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateCalculator.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CalculateDifferenceForYearsSuccess()
        {
            var firstDate = DateTime.Now;
            var secondDate = firstDate.AddYears(5);

            var result = Calculator.CalculateDifference(firstDate, secondDate);

            Assert.AreEqual(5, result.Years);
        }

        [TestMethod]
        public void CalculateDifferenceForMonthsSuccess()
        {
            var firstDate = DateTime.Now;
            var secondDate = firstDate.AddMonths(5);

            var result = Calculator.CalculateDifference(firstDate, secondDate);

            Assert.AreEqual(5, result.Months);
        }

        [TestMethod]
        public void CalculateDifferenceForDaysSuccess()
        {
            var firstDate = DateTime.Now;
            var secondDate = firstDate.AddDays(5);

            var result = Calculator.CalculateDifference(firstDate, secondDate);

            Assert.AreEqual(5, result.Days);
        }

        [TestMethod]
        public void CalculateDifferenceForAllSuccess()
        {
            var firstDate = DateTime.Parse("10/29/1979");
            var secondDate = DateTime.Parse("03/27/2010");

            var result = Calculator.CalculateDifference(firstDate, secondDate);

            Assert.AreEqual(30, result.Years);
            Assert.AreEqual(4, result.Months);
            Assert.AreEqual(27, result.Days);
        }

        [TestMethod]
        public void GetModifiedDateAddYearSuccess()
        {
            var fromDate = DateTime.Parse("10/29/1979");
            const DateFunction function = DateFunction.Add;
            var span = new DateSpan {Years = 1};

            var result = Calculator.GetModifiedDate(fromDate, function, span);

            Assert.AreEqual(1980, result.Year);
        }

        [TestMethod]
        public void GetModifiedDateAddMonthSuccess()
        {
            var fromDate = DateTime.Parse("10/29/1979");
            const DateFunction function = DateFunction.Add;
            var span = new DateSpan { Months = 1 };

            var result = Calculator.GetModifiedDate(fromDate, function, span);

            Assert.AreEqual(11, result.Month);
        }

        [TestMethod]
        public void GetModifiedDateAddDaySuccess()
        {
            var fromDate = DateTime.Parse("10/29/1979");
            const DateFunction function = DateFunction.Add;
            var span = new DateSpan { Days = 1 };

            var result = Calculator.GetModifiedDate(fromDate, function, span);

            Assert.AreEqual(30, result.Day);
        }

        [TestMethod]
        public void GetModifiedDateAddAllSuccess()
        {
            var fromDate = DateTime.Parse("10/29/1979");
            const DateFunction function = DateFunction.Add;
            var span = new DateSpan { Years = 1, Months=1, Days=1 };

            var result = Calculator.GetModifiedDate(fromDate, function, span);

            Assert.AreEqual(DateTime.Parse("11/30/1980").Date, result.Date);
        }

        [TestMethod]
        public void GetModifiedDateSubtractYearSuccess()
        {
            var fromDate = DateTime.Parse("10/29/1979");
            const DateFunction function = DateFunction.Subtract;
            var span = new DateSpan { Years = 1 };

            var result = Calculator.GetModifiedDate(fromDate, function, span);

            Assert.AreEqual(1978, result.Year);
        }

        [TestMethod]
        public void GetModifiedDateSubtractMonthSuccess()
        {
            var fromDate = DateTime.Parse("10/29/1979");
            const DateFunction function = DateFunction.Subtract;
            var span = new DateSpan { Months = 1 };

            var result = Calculator.GetModifiedDate(fromDate, function, span);

            Assert.AreEqual(9, result.Month);
        }

        [TestMethod]
        public void GetModifiedDateSubtractDaySuccess()
        {
            var fromDate = DateTime.Parse("10/29/1979");
            const DateFunction function = DateFunction.Subtract;
            var span = new DateSpan { Days = 1 };

            var result = Calculator.GetModifiedDate(fromDate, function, span);

            Assert.AreEqual(28, result.Day);
        }

        [TestMethod]
        public void GetModifiedDateSubtractAllSuccess()
        {
            var fromDate = DateTime.Parse("10/29/1979");
            const DateFunction function = DateFunction.Subtract;
            var span = new DateSpan { Years = 1, Months=1, Days=1 };

            var result = Calculator.GetModifiedDate(fromDate, function, span);

            Assert.AreEqual(DateTime.Parse("09/28/1978").Date, result.Date);
        }
    }
}
