namespace Schema.NET.Test
{
    using System.Collections.Generic;
    using Xunit;

    public class Values2Test
    {
        [Fact]
        public void Constructor_Value1Passed_OnlyValue1HasValue()
        {
            var values = new Values<int, string>(1);

            Assert.True(values.HasValue1);
            Assert.Equal(1, values.Value1.Count);
            Assert.False(values.HasValue2);
            Assert.Equal(0, values.Value2.Count);
            Assert.Equal(1, ((IValue)values).Value);
        }

        [Fact]
        public void Constructor_Value2Passed_OnlyValue2HasValue()
        {
            var values = new Values<int, string>("Foo");

            Assert.False(values.HasValue1);
            Assert.Equal(1, values.Value1.Count);
            Assert.True(values.HasValue2);
            Assert.Equal(1, values.Value2.Count);
            Assert.Equal("Foo", ((IValue)values).Value);
        }

        [Fact]
        public void ImplicitConversionOperator_Value1Passed_OnlyValue1HasValue()
        {
            Values<int, string> values = 1;

            Assert.True(values.HasValue1);
            Assert.Equal(1, values.Value1.Count);
            Assert.False(values.HasValue2);
            Assert.Equal(0, values.Value2.Count);
            Assert.Equal(1, ((IValue)values).Value);
        }

        [Fact]
        public void ImplicitConversionOperator_Value2Passed_OnlyValue2HasValue()
        {
            Values<int, string> values = "Foo";

            Assert.False(values.HasValue1);
            Assert.Equal(1, values.Value1.Count);
            Assert.True(values.HasValue2);
            Assert.Equal(1, values.Value2.Count);
            Assert.Equal("Foo", ((IValue)values).Value);
        }

        [Fact]
        public void ImplicitConversionOperator_Value1CollectionPassed_OnlyValue1HasValue()
        {
            Values<int, string> values = new List<int>() { 1, 2 };

            Assert.True(values.HasValue1);
            Assert.Equal(2, values.Value1.Count);
            Assert.False(values.HasValue2);
            Assert.Equal(0, values.Value2.Count);
            Assert.Equal(new List<int>() { 1, 2 }, ((IValue)values).Value);
        }

        [Fact]
        public void ImplicitConversionOperator_Value2CollectionPassed_OnlyValue2HasValue()
        {
            Values<int, string> values = new List<string>() { "Foo", "Bar" };

            Assert.False(values.HasValue1);
            Assert.Equal(1, values.Value1.Count);
            Assert.True(values.HasValue2);
            Assert.Equal(2, values.Value2.Count);
            Assert.Equal(new List<string>() { "Foo", "Bar" }, ((IValue)values).Value);
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
    }
}
