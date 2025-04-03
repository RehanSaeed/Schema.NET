namespace Schema.NET.Test;

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

public class Values4Test
{
    [Fact]
    public void Constructor_Value1Passed_OnlyValue1HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person>(1);

        Assert.True(values.HasValue1);
        Assert.Single(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.Equal([1], values.Cast<object>().ToList());
    }

    [Fact]
    public void Constructor_Value2Passed_OnlyValue2HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person>("Foo");

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.True(values.HasValue2);
        Assert.Single(values.Value2);
        Assert.Equal(["Foo"], values.Cast<object>().ToList());
    }

    [Fact]
    public void Constructor_Value3Passed_OnlyValue3HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday);

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.True(values.HasValue3);
        Assert.Single(values.Value3);
        Assert.Equal([DayOfWeek.Friday], values.Cast<object>().ToList());
    }

    [Fact]
    public void Constructor_Value4Passed_OnlyValue4HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person>(new Person());

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.True(values.HasValue4);
        Assert.Single(values.Value4);
        var item = Assert.Single(values.Cast<object>().ToList());
        Assert.IsType<Person>(item);
    }

    [Fact]
    public void Constructor_Items_HasAllItems()
    {
        var person = new Person();
        var values = new Values<int, string, DayOfWeek, Person>(1, "Foo", DayOfWeek.Friday, person);

        Assert.True(values.HasValue1);
        Assert.Single(values.Value1);
        Assert.True(values.HasValue2);
        Assert.Single(values.Value2);
        Assert.True(values.HasValue3);
        Assert.Single(values.Value3);
        Assert.True(values.HasValue4);
        Assert.Single(values.Value4);
        Assert.Equal(
            [1, "Foo", DayOfWeek.Friday, person],
            values.Cast<object>().ToList());
    }

    [Fact]
    public void Constructor_StringItems_NullOrWhitespaceDoesntHaveValue()
    {
        object[] nullOrWhitespaceValues =
        [
            string.Empty,
            null!,
            "\u2028 \u2029 \u0009 \u000A \u000B \u000C \u000D \u0085"
        ];
        var values = new Values<int, string, DayOfWeek, Person>(nullOrWhitespaceValues);

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2, $"{nameof(values.HasValue2)}: Expected: False, Actual: True");
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
    }

    [Fact]
    public void Constructor_NullList_ThrowsArgumentNullException() =>
        Assert.Throws<ArgumentNullException>(() => new Values<int, string, DayOfWeek, Person>((List<object>)null!));

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
        Assert.Equal(expectedCount, new Values<int, string, DayOfWeek, Person>(items).Count);

    [Fact]
    public void HasValue_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(default(Values<int, string, DayOfWeek, Person>).HasValue);

    [Theory]
    [InlineData(1)]
    [InlineData("Foo")]
    [InlineData(DayOfWeek.Friday)]
    public void HasValue_HasValue_ReturnsTrue(params object[] parameters) =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(parameters).HasValue);

    [Fact]
    public void HasValue1_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(1).HasValue1);

    [Fact]
    public void HasValue1_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>("Foo").HasValue1);

    [Fact]
    public void HasValue2_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>("Foo").HasValue2);

    [Fact]
    public void HasValue2_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(1).HasValue2);

    [Fact]
    public void HasValue3_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday).HasValue3);

    [Fact]
    public void HasValue3_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(1).HasValue3);

    [Fact]
    public void HasValue4_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(new Person()).HasValue4);

    [Fact]
    public void HasValue4_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(1).HasValue4);

    [Fact]
    public void ImplicitConversionOperator_Value1Passed_OnlyValue1HasValue()
    {
        Values<int, string, DayOfWeek, Person> values = 1;

        Assert.True(values.HasValue1);
        Assert.Single(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.Equal([1], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value2Passed_OnlyValue2HasValue()
    {
        Values<int, string, DayOfWeek, Person> values = "Foo";

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.True(values.HasValue2);
        Assert.Single(values.Value2);
        Assert.Equal(["Foo"], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value3Passed_OnlyValue3HasValue()
    {
        Values<int, string, DayOfWeek, Person> values = DayOfWeek.Friday;

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.True(values.HasValue3);
        Assert.Single(values.Value3);
        Assert.Equal([DayOfWeek.Friday], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value4Passed_OnlyValue4HasValue()
    {
        Values<int, string, DayOfWeek, Person> values = new Person();

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.True(values.HasValue4);
        Assert.Single(values.Value4);
        var item = Assert.Single(values.Cast<object>().ToList());
        Assert.IsType<Person>(item);
    }

    [Fact]
    public void ImplicitConversionOperator_Value1CollectionPassed_OnlyValue1HasValue()
    {
        Values<int, string, DayOfWeek, Person> values = new List<int> { 1, 2 };

        Assert.True(values.HasValue1);
        Assert.Equal(2, values.Value1.Count);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.Equal([1, 2], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value2CollectionPassed_OnlyValue2HasValue()
    {
        Values<int, string, DayOfWeek, Person> values = new List<string?> { "Foo", "Bar" };

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.True(values.HasValue2);
        Assert.Equal(2, values.Value2.Count);
        Assert.Equal(["Foo", "Bar"], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value3CollectionPassed_OnlyValue3HasValue()
    {
        Values<int, string, DayOfWeek, Person> values = new List<DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Monday };

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.True(values.HasValue3);
        Assert.Equal(2, values.Value3.Count);
        Assert.Equal(
            [DayOfWeek.Friday, DayOfWeek.Monday],
            values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value4CollectionPassed_OnlyValue4HasValue()
    {
        Values<int, string, DayOfWeek, Person> values = new List<Person?> { new Person(), new Person() };

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.True(values.HasValue4);
        Assert.Equal(2, values.Value4.Count);
        Assert.Equal(2, values.Cast<object>().ToList().Count);
    }

    [Fact]
    public void ImplicitConversionToList_Value1Passed_ReturnsMatchingList()
    {
        List<int> values = new Values<int, string, DayOfWeek, Person>(1);

        Assert.Equal([1], values);
    }

    [Fact]
    public void ImplicitConversionToList_Value2Passed_ReturnsMatchingList()
    {
        List<string> values = new Values<int, string, DayOfWeek, Person>("Foo");

        Assert.Equal(["Foo"], values);
    }

    [Fact]
    public void ImplicitConversionToList_Value3Passed_ReturnsMatchingList()
    {
        List<DayOfWeek> values = new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday);

        Assert.Equal([DayOfWeek.Friday], values);
    }

    [Fact]
    public void ImplicitConversionToList_Value4Passed_ReturnsMatchingList()
    {
        var person = new Person();
        List<Person> values = new Values<int, string, DayOfWeek, Person>(person);

        Assert.Equal([person], values);
    }

    [Fact]
    public void Deconstruct_Values_ReturnsAllEnumerables()
    {
        var person = new Person();
        var (integers, strings, daysOfWeek, people) = new Values<int, string, DayOfWeek, Person>(1, "Foo", DayOfWeek.Friday, person);
        Assert.Equal(new List<int> { 1 }, integers);
        Assert.Equal(new List<string> { "Foo" }, strings);
        Assert.Equal(new List<DayOfWeek> { DayOfWeek.Friday }, daysOfWeek);
        Assert.Equal(new List<Person> { person }, people);
    }

    [Fact]
    public void EqualsOperator_EqualValue1Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(1) == new Values<int, string, DayOfWeek, Person>(1));

    [Fact]
    public void EqualsOperator_NotEqualValue1Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(1) == new Values<int, string, DayOfWeek, Person>(2));

    [Fact]
    public void EqualsOperator_EqualValue2Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>("Foo") == new Values<int, string, DayOfWeek, Person>("Foo"));

    [Fact]
    public void EqualsOperator_NotEqualValue2Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>("Foo") == new Values<int, string, DayOfWeek, Person>("Bar"));

    [Fact]
    public void EqualsOperator_EqualValue3Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday) == new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday));

    [Fact]
    public void EqualsOperator_NotEqualValue3Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday) == new Values<int, string, DayOfWeek, Person>(DayOfWeek.Monday));

    [Fact]
    public void EqualsOperator_EqualValue4Passed_ReturnsTrue()
    {
        var person = new Person();
        Assert.True(new Values<int, string, DayOfWeek, Person>(person) == new Values<int, string, DayOfWeek, Person>(person));
    }

    [Fact]
    public void EqualsOperator_NotEqualValue4Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new Person { Name = "A" }) == new Values<int, string, DayOfWeek, Person>(new Person { Name = "B" }));

    [Fact]
    public void NotEqualsOperator_EqualValue1Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(1) != new Values<int, string, DayOfWeek, Person>(1));

    [Fact]
    public void NotEqualsOperator_NotEqualValue1Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(1) != new Values<int, string, DayOfWeek, Person>(2));

    [Fact]
    public void NotEqualsOperator_EqualValue2Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>("Foo") != new Values<int, string, DayOfWeek, Person>("Foo"));

    [Fact]
    public void NotEqualsOperator_NotEqualValue2Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>("Foo") != new Values<int, string, DayOfWeek, Person>("Bar"));

    [Fact]
    public void NotEqualsOperator_EqualValue3Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday) != new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday));

    [Fact]
    public void NotEqualsOperator_NotEqualValue3Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday) != new Values<int, string, DayOfWeek, Person>(DayOfWeek.Monday));

    [Fact]
    public void NotEqualsOperator_EqualValue4Passed_ReturnsFalse()
    {
        var person = new Person();
        Assert.False(new Values<int, string, DayOfWeek, Person>(person) != new Values<int, string, DayOfWeek, Person>(person));
    }

    [Fact]
    public void NotEqualsOperator_NotEqualValue4Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(new Person { Name = "A" }) != new Values<int, string, DayOfWeek, Person>(new Person { Name = "B" }));

    [Fact]
    public void Equals_EqualValue1Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(1).Equals(new Values<int, string, DayOfWeek, Person>(1)));

    [Fact]
    public void Equals_NotEqualValue1Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(1).Equals(new Values<int, string, DayOfWeek, Person>(2)));

    [Fact]
    public void Equals_EqualValue2Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>("Foo").Equals(new Values<int, string, DayOfWeek, Person>("Foo")));

    [Fact]
    public void Equals_NotEqualValue2Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>("Foo").Equals(new Values<int, string, DayOfWeek, Person>("Bar")));

    [Fact]
    public void Equals_EqualValue3Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday).Equals(new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday)));

    [Fact]
    public void Equals_NotEqualValue3Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(DayOfWeek.Friday).Equals(new Values<int, string, DayOfWeek, Person>(DayOfWeek.Monday)));

    [Fact]
    public void Equals_EqualValue4Passed_ReturnsTrue()
    {
        var person = new Person();
        Assert.True(new Values<int, string, DayOfWeek, Person>(person).Equals(new Values<int, string, DayOfWeek, Person>(person)));
    }

    [Fact]
    public void Equals_NotEqualValue4Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new Person { Name = "A" }).Equals(new Values<int, string, DayOfWeek, Person>(new Person { Name = "B" })));

    [Fact]
    public void Equals_MixedTypes_Value1EqualValue2EqualValue3EqualValue4NotEqual_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person { Name = "Schema" } })));

    [Fact]
    public void Equals_MixedTypes_Value1EqualValue2EqualValue3NotEqualValue4Equal_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Wednesday, new Person() })));

    [Fact]
    public void Equals_MixedTypes_Value1EqualValue2NotEqualValue3EqualValue4Equal_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Bar", DayOfWeek.Tuesday, new Person() })));

    [Fact]
    public void Equals_MixedTypes_Value1NotEqualValue2EqualValue3EqualValue4Equal_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 1, "Foo", DayOfWeek.Tuesday, new Person() })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue4_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue3_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue2_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, DayOfWeek.Tuesday, new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue1_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { "Foo", DayOfWeek.Tuesday, new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue4_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue3_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", new Person() })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue2_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { 0, DayOfWeek.Tuesday, new Person() })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue1_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person() }).Equals(new Values<int, string, DayOfWeek, Person>(new object[] { "Foo", DayOfWeek.Tuesday, new Person() })));

    [Fact]
    public void GetHashCode_Value1Passed_ReturnsMatchingHashCode() =>
        Assert.Equal(
            CombineHashCodes(CombineHashCodes(CombineHashCodes(1.GetHashCode(), 0), 0), 0),
            new Values<int, string, DayOfWeek?, Person>(1).GetHashCode());

    [Fact]
    public void GetHashCode_Value2Passed_ReturnsMatchingHashCode() =>
        Assert.Equal(
            CombineHashCodes(CombineHashCodes("Foo".GetHashCode(
#if !NET48
                StringComparison.Ordinal
#endif
            ), 0), 0),
            new Values<int, string, DayOfWeek?, Person>("Foo").GetHashCode());

    [Fact]
    public void GetHashCode_Value3Passed_ReturnsMatchingHashCode() =>
        Assert.Equal(
            CombineHashCodes(DayOfWeek.Friday.GetHashCode(), 0),
            new Values<int, string, DayOfWeek?, Person>(DayOfWeek.Friday).GetHashCode());

    [Fact]
    public void GetHashCode_Value4Passed_ReturnsMatchingHashCode()
    {
        var person = new Person();
        Assert.Equal(person.GetHashCode(), new Values<int, string, DayOfWeek?, Person>(person).GetHashCode());
    }

    private static int CombineHashCodes(int h1, int h2) => ((h1 << 5) + h1) ^ h2;
}
