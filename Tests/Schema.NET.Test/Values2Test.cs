namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class Values2Test
    {
        [Fact]
        public void Constructor_Value1Passed_OnlyValue1HasValue()
        {
            var values = new Values<int, string>(1);

            Assert.True(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.False(values.HasValue2);
            Assert.Empty(values.Value2);
            Assert.Equal(new List<object>() { 1 }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void Constructor_Value2Passed_OnlyValue2HasValue()
        {
            var values = new Values<int, string>("Foo");

            Assert.False(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.True(values.HasValue2);
            Assert.Single(values.Value2);
            Assert.Equal(new List<object>() { "Foo" }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void Constructor_Items_HasAllItems()
        {
            var values = new Values<int, string>(1, "Foo");

            Assert.True(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.True(values.HasValue2);
            Assert.Single(values.Value2);
            Assert.Equal(new List<object>() { 1, "Foo" }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void Constructor_NullList_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => new Values<int, string>((List<object>)null));

        [Theory]
        [InlineData(0)]
        [InlineData(1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(1, "Foo")]
        [InlineData(2, "Foo", "Bar")]
        [InlineData(2, 1, "Foo")]
        [InlineData(4, 1, 2, "Foo", "Bar")]
        public void Count_Items_ReturnsExpectedCount(int expectedCount, params object[] items) =>
            Assert.Equal(expectedCount, new Values<int, string>(items).Count);

        [Fact]
        public void HasValue_DoesntHaveValue_ReturnsFalse() =>
            Assert.False(default(Values<int, string>).HasValue);

        [Theory]
        [InlineData(1)]
        [InlineData("Foo")]
        public void HasValue_HasValue_ReturnsTrue(params object[] parameters) =>
            Assert.True(new Values<int, string>(parameters).HasValue);

        [Fact]
        public void HasValue1_HasValue_ReturnsTrue() => Assert.True(new Values<int, string>(1).HasValue1);

        [Fact]
        public void HasValue1_DoesntHaveValue_ReturnsFalse() => Assert.False(new Values<int, string>("Foo").HasValue1);

        [Fact]
        public void HasValue2_HasValue_ReturnsTrue() => Assert.True(new Values<int, string>("Foo").HasValue2);

        [Fact]
        public void HasValue2_DoesntHaveValue_ReturnsFalse() => Assert.False(new Values<int, string>(1).HasValue2);

        [Fact]
        public void ImplicitConversionOperator_Value1Passed_OnlyValue1HasValue()
        {
            Values<int, string> values = 1;

            Assert.True(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.False(values.HasValue2);
            Assert.Empty(values.Value2);
            Assert.Equal(new List<object>() { 1 }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void ImplicitConversionOperator_Value2Passed_OnlyValue2HasValue()
        {
            Values<int, string> values = "Foo";

            Assert.False(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.True(values.HasValue2);
            Assert.Single(values.Value2);
            Assert.Equal(new List<object>() { "Foo" }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void ImplicitConversionOperator_Value1ListPassed_OnlyValue1HasValue()
        {
            Values<int, string> values = new List<int>() { 1, 2 };

            Assert.True(values.HasValue1);
            Assert.Equal(2, values.Value1.Count);
            Assert.False(values.HasValue2);
            Assert.Empty(values.Value2);
            Assert.Equal(new List<object>() { 1, 2 }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void ImplicitConversionOperator_Value2ListPassed_OnlyValue2HasValue()
        {
            Values<int, string> values = new List<string>() { "Foo", "Bar" };

            Assert.False(values.HasValue1);
            Assert.Single(values.Value1);
            Assert.True(values.HasValue2);
            Assert.Equal(2, values.Value2.Count);
            Assert.Equal(new List<object>() { "Foo", "Bar" }, ((IValues)values).Cast<object>().ToList());
        }

        [Fact]
        public void ImplicitConversionToList_Value1Passed_ReturnsMatchingList()
        {
            List<int> values = new Values<int, string>(1);

            Assert.Equal(new List<int>() { 1 }, values);
        }

        [Fact]
        public void ImplicitConversionToList_Value2Passed_ReturnsMatchingList()
        {
            List<string> values = new Values<int, string>("Foo");

            Assert.Equal(new List<string>() { "Foo" }, values);
        }

        [Fact]
        public void Deconstruct_Values_ReturnsAllEnumerables()
        {
            var (integers, strings) = new Values<int, string>(1, "Foo");
            Assert.Equal(new List<int>() { 1 }, integers);
            Assert.Equal(new List<string>() { "Foo" }, strings);
        }

        [Fact]
        public void EqualsOperator_EqualValue1Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string>(1) == new Values<int, string>(1));

        [Fact]
        public void EqualsOperator_NotEqualValue1Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string>(1) == new Values<int, string>(2));

        [Fact]
        public void EqualsOperator_EqualValue2Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string>("Foo") == new Values<int, string>("Foo"));

        [Fact]
        public void EqualsOperator_NotEqualValue2Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string>("Foo") == new Values<int, string>("Bar"));

        [Fact]
        public void NotEqualsOperator_EqualValue1Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string>(1) != new Values<int, string>(1));

        [Fact]
        public void NotEqualsOperator_NotEqualValue1Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string>(1) != new Values<int, string>(2));

        [Fact]
        public void NotEqualsOperator_EqualValue2Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string>("Foo") != new Values<int, string>("Foo"));

        [Fact]
        public void NotEqualsOperator_NotEqualValue2Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string>("Foo") != new Values<int, string>("Bar"));

        [Fact]
        public void Equals_EqualValue1Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string>(1).Equals(new Values<int, string>(1)));

        [Fact]
        public void Equals_NotEqualValue1Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string>(1).Equals(new Values<int, string>(2)));

        [Fact]
        public void Equals_EqualValue2Passed_ReturnsTrue() =>
            Assert.True(new Values<int, string>("Foo").Equals(new Values<int, string>("Foo")));

        [Fact]
        public void Equals_NotEqualValue2Passed_ReturnsFalse() =>
            Assert.False(new Values<int, string>("Foo").Equals(new Values<int, string>("Bar")));

        [Fact]
        public void GetHashCode_Value1Passed_ReturnsMatchingHashCode() =>
            Assert.Equal(1.GetHashCode(), new Values<int, string>(1).GetHashCode());

        [Fact]
        public void GetHashCode_Value2Passed_ReturnsMatchingHashCode() =>
            Assert.Equal("Foo".GetHashCode(), new Values<int, string>("Foo").GetHashCode());

        [Fact]
        public void GetHashCode_Value1And2Passed_ReturnsMatchingHashCode() =>
            Assert.Equal(
                NET.HashCode.Of(1).And("Foo"),
                new Values<int, string>(new List<object>() { 1, "Foo" }).GetHashCode());
    }
}
