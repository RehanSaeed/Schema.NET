namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class Values3Test
    {
        [Fact]
        public void Constructor_Value1Passed_OnlyValue1HasValue()
        {
            var values = new Values<int, string, DayOfWeek>(1);

            Assert.True(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.False(values.HasValue2);
            Assert.Empty(values.Value2);
            Assert.Equal(new List<object>() { 1 }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void Constructor_Value2Passed_OnlyValue2HasValue()
        {
            var values = new Values<int, string, DayOfWeek>("Foo");

            Assert.False(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.True(values.HasValue2);
            Assert.Single(values.Value2);
            Assert.Equal(new List<object>() { "Foo" }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void Constructor_Value3Passed_OnlyValue3HasValue()
        {
            var values = new Values<int, string, DayOfWeek>(DayOfWeek.Friday);

            Assert.False(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.False(values.HasValue2);
            Assert.Empty(values.Value2);
            Assert.True(values.HasValue3);
            Assert.Single(values.Value3);
            Assert.Equal(new List<object>() { DayOfWeek.Friday }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void Constructor_Items_HasAllItems()
        {
            var values = new Values<int, string, DayOfWeek>(1, "Foo", DayOfWeek.Friday);

            Assert.True(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.True(values.HasValue2);
            Assert.Single(values.Value2);
            Assert.True(values.HasValue3);
            Assert.Single(values.Value3);
            Assert.Equal(new List<object>() { 1, "Foo", DayOfWeek.Friday }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void Constructor_NullList_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => new Values<int, string, DayOfWeek>((List<object>)null));

        [Theory]
        [InlineData(0)]
        [InlineData(1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(1, "Foo")]
        [InlineData(2, "Foo", "Bar")]
        [InlineData(1, DayOfWeek.Friday)]
        [InlineData(2, DayOfWeek.Friday, DayOfWeek.Monday)]
        [InlineData(3, 1, "Foo", DayOfWeek.Friday)]
        [InlineData(6, 1, 2, "Foo", "Bar", DayOfWeek.Friday, DayOfWeek.Monday)]
        public void Count_Items_ReturnsExpectedCount(int expectedCount, params object[] items) =>
            Assert.Equal(expectedCount, new Values<int, string, DayOfWeek>(items).Count);

        [Fact]
        public void HasValue_DoesntHaveValue_ReturnsFalse() =>
            Assert.False(default(Values<int, string, DayOfWeek>).HasValue);

        [Theory]
        [InlineData(1)]
        [InlineData("Foo")]
        [InlineData(DayOfWeek.Friday)]
        public void HasValue_HasValue_ReturnsTrue(params object[] parameters) =>
            Assert.True(new Values<int, string, DayOfWeek>(parameters).HasValue);

        [Fact]
        public void HasValue1_HasValue_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>(1).HasValue1);

        [Fact]
        public void HasValue1_DoesntHaveValue_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>("Foo").HasValue1);

        [Fact]
        public void HasValue2_HasValue_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>("Foo").HasValue2);

        [Fact]
        public void HasValue2_DoesntHaveValue_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>(1).HasValue2);

        [Fact]
        public void HasValue3_HasValue_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>(DayOfWeek.Friday).HasValue3);

        [Fact]
        public void HasValue3_DoesntHaveValue_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>(1).HasValue3);

        [Fact]
        public void ImplicitConversionOperator_Value1Passed_OnlyValue1HasValue()
        {
            Values<int, string, DayOfWeek> values = 1;

            Assert.True(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.False(values.HasValue2);
            Assert.Empty(values.Value2);
            Assert.Equal(new List<object>() { 1 }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void ImplicitConversionOperator_Value2Passed_OnlyValue2HasValue()
        {
            Values<int, string, DayOfWeek> values = "Foo";

            Assert.False(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.True(values.HasValue2);
            Assert.Single(values.Value2);
            Assert.Equal(new List<object>() { "Foo" }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void ImplicitConversionOperator_Value3Passed_OnlyValue3HasValue()
        {
            Values<int, string, DayOfWeek> values = DayOfWeek.Friday;

            Assert.False(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.False(values.HasValue2);
            Assert.Empty(values.Value2);
            Assert.True(values.HasValue3);
            Assert.Single(values.Value3);
            Assert.Equal(new List<object>() { DayOfWeek.Friday }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void ImplicitConversionOperator_Value1CollectionPassed_OnlyValue1HasValue()
        {
            Values<int, string, DayOfWeek> values = new List<int>() { 1, 2 };

            Assert.True(values.HasValue1);
            Assert.Equal(2, values.Value1.Count);
            Assert.False(values.HasValue2);
            Assert.Empty(values.Value2);
            Assert.Equal(new List<object>() { 1, 2 }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void ImplicitConversionOperator_Value2CollectionPassed_OnlyValue2HasValue()
        {
            Values<int, string, DayOfWeek> values = new List<string>() { "Foo", "Bar" };

            Assert.False(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.True(values.HasValue2);
            Assert.Equal(2, values.Value2.Count);
            Assert.Equal(new List<string>() { "Foo", "Bar" }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void ImplicitConversionOperator_Value3CollectionPassed_OnlyValue3HasValue()
        {
            Values<int, string, DayOfWeek> values = new List<DayOfWeek>() { DayOfWeek.Friday, DayOfWeek.Monday };

            Assert.False(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.False(values.HasValue2);
            Assert.Empty(values.Value2);
            Assert.True(values.HasValue3);
            Assert.Equal(2, values.Value3.Count);
            Assert.Equal(new List<object>() { DayOfWeek.Friday, DayOfWeek.Monday }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void ImplicitConversionToList_Value1Passed_ReturnsMatchingList()
        {
            List<int> values = new Values<int, string, DayOfWeek>(1);

            Assert.Equal(new List<int>() { 1 }, values);
        }

        [Fact]
        public void ImplicitConversionToList_Value2Passed_ReturnsMatchingList()
        {
            List<string> values = new Values<int, string, DayOfWeek>("Foo");

            Assert.Equal(new List<string>() { "Foo" }, values);
        }

        [Fact]
        public void ImplicitConversionToList_Value3Passed_ReturnsMatchingList()
        {
            List<DayOfWeek> values = new Values<int, string, DayOfWeek>(DayOfWeek.Friday);

            Assert.Equal(new List<DayOfWeek>() { DayOfWeek.Friday }, values);
        }

        [Fact]
        public void Deconstruct_Values_ReturnsAllEnumerables()
        {
            var (integers, strings, daysOfWeek) = new Values<int, string, DayOfWeek>(1, "Foo", DayOfWeek.Friday);
            Assert.Equal(new List<int>() { 1 }, integers);
            Assert.Equal(new List<string>() { "Foo" }, strings);
            Assert.Equal(new List<DayOfWeek>() { DayOfWeek.Friday }, daysOfWeek);
        }

        [Fact]
        public void EqualsOperator_EqualValue1Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>(1) == new Values<int, string, DayOfWeek>(1));

        [Fact]
        public void EqualsOperator_NotEqualValue1Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>(1) == new Values<int, string, DayOfWeek>(2));

        [Fact]
        public void EqualsOperator_EqualValue2Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>("Foo") == new Values<int, string, DayOfWeek>("Foo"));

        [Fact]
        public void EqualsOperator_NotEqualValue2Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>("Foo") == new Values<int, string, DayOfWeek>("Bar"));

        [Fact]
        public void EqualsOperator_EqualValue3Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>(DayOfWeek.Friday) == new Values<int, string, DayOfWeek>(DayOfWeek.Friday));

        [Fact]
        public void EqualsOperator_NotEqualValue3Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>(DayOfWeek.Friday) == new Values<int, string, DayOfWeek>(DayOfWeek.Monday));

        [Fact]
        public void NotEqualsOperator_EqualValue1Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>(1) != new Values<int, string, DayOfWeek>(1));

        [Fact]
        public void NotEqualsOperator_NotEqualValue1Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>(1) != new Values<int, string, DayOfWeek>(2));

        [Fact]
        public void NotEqualsOperator_EqualValue2Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>("Foo") != new Values<int, string, DayOfWeek>("Foo"));

        [Fact]
        public void NotEqualsOperator_NotEqualValue2Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>("Foo") != new Values<int, string, DayOfWeek>("Bar"));

        [Fact]
        public void NotEqualsOperator_EqualValue3Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>(DayOfWeek.Friday) != new Values<int, string, DayOfWeek>(DayOfWeek.Friday));

        [Fact]
        public void NotEqualsOperator_NotEqualValue3Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>(DayOfWeek.Friday) != new Values<int, string, DayOfWeek>(DayOfWeek.Monday));

        [Fact]
        public void Equals_EqualValue1Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>(1).Equals(new Values<int, string, DayOfWeek>(1)));

        [Fact]
        public void Equals_NotEqualValue1Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>(1).Equals(new Values<int, string, DayOfWeek>(2)));

        [Fact]
        public void Equals_EqualValue2Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>("Foo").Equals(new Values<int, string, DayOfWeek>("Foo")));

        [Fact]
        public void Equals_NotEqualValue2Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>("Foo").Equals(new Values<int, string, DayOfWeek>("Bar")));

        [Fact]
        public void Equals_EqualValue3Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string, DayOfWeek>(DayOfWeek.Friday).Equals(new Values<int, string, DayOfWeek>(DayOfWeek.Friday)));

        [Fact]
        public void Equals_NotEqualValue3Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string, DayOfWeek>(DayOfWeek.Friday).Equals(new Values<int, string, DayOfWeek>(DayOfWeek.Monday)));

        [Fact]
        public void GetHashCode_Value1Passed_ReturnsMatchingHashCode() =>
            Assert.Equal(
                CombineHashCodes(CombineHashCodes(1.GetHashCode(), 0), 0),
                new Values<int, string, DayOfWeek?>(1).GetHashCode());

        [Fact]
        public void GetHashCode_Value2Passed_ReturnsMatchingHashCode() =>
            Assert.Equal(
                CombineHashCodes("Foo".GetHashCode(StringComparison.Ordinal), 0),
                new Values<int, string, DayOfWeek?>("Foo").GetHashCode());

        [Fact]
        public void GetHashCode_Value3Passed_ReturnsMatchingHashCode() =>
            Assert.Equal(DayOfWeek.Friday.GetHashCode(), new Values<int, string, DayOfWeek?>(DayOfWeek.Friday).GetHashCode());

        private static int CombineHashCodes(int h1, int h2) => ((h1 << 5) + h1) ^ h2;
    }
}
