namespace Schema.NET.Test;

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

public class Values7Test
{
    [Fact]
    public void Constructor_Value1Passed_OnlyValue1HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1);

        Assert.True(values.HasValue1);
        Assert.Single(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal([1], values.Cast<object>().ToList());
    }

    [Fact]
    public void Constructor_Value2Passed_OnlyValue2HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo");

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.True(values.HasValue2);
        Assert.Single(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal(["Foo"], values.Cast<object>().ToList());
    }

    [Fact]
    public void Constructor_Value3Passed_OnlyValue3HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday);

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.True(values.HasValue3);
        Assert.Single(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal([DayOfWeek.Friday], values.Cast<object>().ToList());
    }

    [Fact]
    public void Constructor_Value4Passed_OnlyValue4HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new Person());

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.True(values.HasValue4);
        Assert.Single(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        var item = Assert.Single(values.Cast<object>().ToList());
        Assert.IsType<Person>(item);
    }

    [Fact]
    public void Constructor_Value5Passed_OnlyValue5HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue);

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.True(values.HasValue5);
        Assert.Single(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        var item = Assert.Single(values.Cast<object>().ToList());
        Assert.IsType<DateTime>(item);
    }

    [Fact]
    public void Constructor_Value6Passed_OnlyValue6HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true);

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.True(values.HasValue6);
        Assert.Single(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        var item = Assert.Single(values.Cast<object>().ToList());
        Assert.IsType<bool>(item);
    }

    [Fact]
    public void Constructor_Value7Passed_OnlyValue7HasValue()
    {
        var values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue);

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.True(values.HasValue7);
        Assert.Single(values.Value7);
        var item = Assert.Single(values.Cast<object>().ToList());
        Assert.IsType<TimeSpan>(item);
    }

    [Fact]
    public void Constructor_Items_HasAllItems()
    {
        var person = new Person();
        var values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1, "Foo", DayOfWeek.Friday, person, DateTime.MinValue, true, TimeSpan.MinValue);

        Assert.True(values.HasValue1);
        Assert.Single(values.Value1);
        Assert.True(values.HasValue2);
        Assert.Single(values.Value2);
        Assert.True(values.HasValue3);
        Assert.Single(values.Value3);
        Assert.True(values.HasValue4);
        Assert.Single(values.Value4);
        Assert.True(values.HasValue5);
        Assert.Single(values.Value5);
        Assert.True(values.HasValue6);
        Assert.Single(values.Value6);
        Assert.True(values.HasValue7);
        Assert.Single(values.Value7);
        Assert.Equal(
            [1, "Foo", DayOfWeek.Friday, person, DateTime.MinValue, true, TimeSpan.MinValue],
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
        var values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(nullOrWhitespaceValues);

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2, $"{nameof(values.HasValue2)}: Expected: False, Actual: True");
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
    }

    [Fact]
    public void Constructor_NullList_ThrowsArgumentNullException() =>
        Assert.Throws<ArgumentNullException>(() => new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>((List<object>)null!));

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
        Assert.Equal(expectedCount, new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(items).Count);

    [Fact]
    public void HasValue_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(default(Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>).HasValue);

    [Theory]
    [InlineData(1)]
    [InlineData("Foo")]
    [InlineData(DayOfWeek.Friday)]
    public void HasValue_HasValue_ReturnsTrue(params object[] parameters) =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(parameters).HasValue);

    [Fact]
    public void HasValue1_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1).HasValue1);

    [Fact]
    public void HasValue1_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo").HasValue1);

    [Fact]
    public void HasValue2_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo").HasValue2);

    [Fact]
    public void HasValue2_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1).HasValue2);

    [Fact]
    public void HasValue3_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday).HasValue3);

    [Fact]
    public void HasValue3_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1).HasValue3);

    [Fact]
    public void HasValue4_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new Person()).HasValue4);

    [Fact]
    public void HasValue4_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1).HasValue4);

    [Fact]
    public void HasValue5_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue).HasValue5);

    [Fact]
    public void HasValue5_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1).HasValue5);

    [Fact]
    public void HasValue6_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true).HasValue6);

    [Fact]
    public void HasValue6_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1).HasValue6);

    [Fact]
    public void HasValue7_HasValue_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue).HasValue7);

    [Fact]
    public void HasValue7_DoesntHaveValue_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1).HasValue7);

    [Fact]
    public void ImplicitConversionOperator_Value1Passed_OnlyValue1HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = 1;

        Assert.True(values.HasValue1);
        Assert.Single(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal([1], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value2Passed_OnlyValue2HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = "Foo";

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.True(values.HasValue2);
        Assert.Single(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal(["Foo"], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value3Passed_OnlyValue3HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = DayOfWeek.Friday;

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.True(values.HasValue3);
        Assert.Single(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal([DayOfWeek.Friday], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value4Passed_OnlyValue4HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = new Person();

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.True(values.HasValue4);
        Assert.Single(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        var item = Assert.Single(values.Cast<object>().ToList());
        Assert.IsType<Person>(item);
    }

    [Fact]
    public void ImplicitConversionOperator_Value5Passed_OnlyValue5HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = DateTime.MinValue;

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.True(values.HasValue5);
        Assert.Single(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        var item = Assert.Single(values.Cast<object>().ToList());
        Assert.IsType<DateTime>(item);
    }

    [Fact]
    public void ImplicitConversionOperator_Value6Passed_OnlyValue6HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = true;

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.True(values.HasValue6);
        Assert.Single(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        var item = Assert.Single(values.Cast<object>().ToList());
        Assert.IsType<bool>(item);
    }

    [Fact]
    public void ImplicitConversionOperator_Value7Passed_OnlyValue7HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = TimeSpan.MinValue;

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.True(values.HasValue7);
        Assert.Single(values.Value7);
        var item = Assert.Single(values.Cast<object>().ToList());
        Assert.IsType<TimeSpan>(item);
    }

    [Fact]
    public void ImplicitConversionOperator_Value1CollectionPassed_OnlyValue1HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = new List<int> { 1, 2 };

        Assert.True(values.HasValue1);
        Assert.Equal(2, values.Value1.Count);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal([1, 2], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value2CollectionPassed_OnlyValue2HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = new List<string?> { "Foo", "Bar" };

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.True(values.HasValue2);
        Assert.Equal(2, values.Value2.Count);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal(["Foo", "Bar"], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value3CollectionPassed_OnlyValue3HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = new List<DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Monday };

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.True(values.HasValue3);
        Assert.Equal(2, values.Value3.Count);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal([DayOfWeek.Friday, DayOfWeek.Monday], values.Cast<object>().ToList());
    }

    [Fact]
    public void ImplicitConversionOperator_Value4CollectionPassed_OnlyValue4HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = new List<Person?> { new Person(), new Person() };

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.True(values.HasValue4);
        Assert.Equal(2, values.Value4.Count);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal(2, values.Cast<object>().ToList().Count);
    }

    [Fact]
    public void ImplicitConversionOperator_Value5CollectionPassed_OnlyValue5HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = new List<DateTime> { DateTime.MinValue, DateTime.MinValue };

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.True(values.HasValue5);
        Assert.Equal(2, values.Value5.Count);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal(2, values.Cast<object>().ToList().Count);
    }

    [Fact]
    public void ImplicitConversionOperator_Value6CollectionPassed_OnlyValue6HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = new List<bool> { true, true };

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.True(values.HasValue6);
        Assert.Equal(2, values.Value6.Count);
        Assert.False(values.HasValue7);
        Assert.Empty(values.Value7);
        Assert.Equal(2, values.Cast<object>().ToList().Count);
    }

    [Fact]
    public void ImplicitConversionOperator_Value7CollectionPassed_OnlyValue7HasValue()
    {
        Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan> values = new List<TimeSpan> { TimeSpan.MinValue, TimeSpan.MinValue };

        Assert.False(values.HasValue1);
        Assert.Empty(values.Value1);
        Assert.False(values.HasValue2);
        AssertEx.Empty(values.Value2);
        Assert.False(values.HasValue3);
        Assert.Empty(values.Value3);
        Assert.False(values.HasValue4);
        Assert.Empty(values.Value4);
        Assert.False(values.HasValue5);
        Assert.Empty(values.Value5);
        Assert.False(values.HasValue6);
        Assert.Empty(values.Value6);
        Assert.True(values.HasValue7);
        Assert.Equal(2, values.Value7.Count);
        Assert.Equal(2, values.Cast<object>().ToList().Count);
    }

    [Fact]
    public void ImplicitConversionToList_Value1Passed_ReturnsMatchingList()
    {
        List<int> values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1);

        Assert.Equal([1], values);
    }

    [Fact]
    public void ImplicitConversionToList_Value2Passed_ReturnsMatchingList()
    {
        List<string> values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo");

        Assert.Equal(["Foo"], values);
    }

    [Fact]
    public void ImplicitConversionToList_Value3Passed_ReturnsMatchingList()
    {
        List<DayOfWeek> values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday);

        Assert.Equal([DayOfWeek.Friday], values);
    }

    [Fact]
    public void ImplicitConversionToList_Value4Passed_ReturnsMatchingList()
    {
        var person = new Person();
        List<Person> values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(person);

        Assert.Equal([person], values);
    }

    [Fact]
    public void ImplicitConversionToList_Value5Passed_ReturnsMatchingList()
    {
        List<DateTime> values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue);

        Assert.Equal([DateTime.MinValue], values);
    }

    [Fact]
    public void ImplicitConversionToList_Value6Passed_ReturnsMatchingList()
    {
        List<bool> values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true);

        Assert.Equal([true], values);
    }

    [Fact]
    public void ImplicitConversionToList_Value7Passed_ReturnsMatchingList()
    {
        List<TimeSpan> values = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue);

        Assert.Equal([TimeSpan.MinValue], values);
    }

    [Fact]
    public void Deconstruct_Values_ReturnsAllEnumerables()
    {
        var person = new Person();
        var (integers, strings, daysOfWeek, people, dates, bools, times) = new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1, "Foo", DayOfWeek.Friday, person, DateTime.MinValue, true, TimeSpan.MinValue);
        Assert.Equal(new List<int> { 1 }, integers);
        Assert.Equal(new List<string> { "Foo" }, strings);
        Assert.Equal(new List<DayOfWeek> { DayOfWeek.Friday }, daysOfWeek);
        Assert.Equal(new List<Person> { person }, people);
        Assert.Equal(new List<DateTime> { DateTime.MinValue }, dates);
        Assert.Equal(new List<bool> { true }, bools);
        Assert.Equal(new List<TimeSpan> { TimeSpan.MinValue }, times);
    }

    [Fact]
    public void EqualsOperator_EqualValue1Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1));

    [Fact]
    public void EqualsOperator_NotEqualValue1Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(2));

    [Fact]
    public void EqualsOperator_EqualValue2Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo") == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo"));

    [Fact]
    public void EqualsOperator_NotEqualValue2Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo") == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Bar"));

    [Fact]
    public void EqualsOperator_EqualValue3Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday));

    [Fact]
    public void EqualsOperator_NotEqualValue3Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Monday));

    [Fact]
    public void EqualsOperator_EqualValue4Passed_ReturnsTrue()
    {
        var person = new Person();
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(person) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(person));
    }

    [Fact]
    public void EqualsOperator_NotEqualValue4Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new Person { Name = "A" }) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new Person { Name = "B" }));

    [Fact]
    public void EqualsOperator_EqualValue5Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue));

    [Fact]
    public void EqualsOperator_NotEqualValue5Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MaxValue));

    [Fact]
    public void EqualsOperator_EqualValue6Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true));

    [Fact]
    public void EqualsOperator_NotEqualValue6Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(false));

    [Fact]
    public void EqualsOperator_EqualValue7Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue));

    [Fact]
    public void EqualsOperator_NotEqualValue7Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue) == new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MaxValue));

    [Fact]
    public void NotEqualsOperator_EqualValue1Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1));

    [Fact]
    public void NotEqualsOperator_NotEqualValue1Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(2));

    [Fact]
    public void NotEqualsOperator_EqualValue2Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo") != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo"));

    [Fact]
    public void NotEqualsOperator_NotEqualValue2Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo") != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Bar"));

    [Fact]
    public void NotEqualsOperator_EqualValue3Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday));

    [Fact]
    public void NotEqualsOperator_NotEqualValue3Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Monday));

    [Fact]
    public void NotEqualsOperator_EqualValue4Passed_ReturnsFalse()
    {
        var person = new Person();
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(person) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(person));
    }

    [Fact]
    public void NotEqualsOperator_NotEqualValue4Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new Person { Name = "A" }) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new Person { Name = "B" }));

    [Fact]
    public void NotEqualsOperator_EqualValue5Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue));

    [Fact]
    public void NotEqualsOperator_NotEqualValue5Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MaxValue));

    [Fact]
    public void NotEqualsOperator_EqualValue6Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true));

    [Fact]
    public void NotEqualsOperator_NotEqualValue6Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(false));

    [Fact]
    public void NotEqualsOperator_EqualValue7Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue));

    [Fact]
    public void NotEqualsOperator_NotEqualValue7Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue) != new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MaxValue));

    [Fact]
    public void Equals_EqualValue1Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1)));

    [Fact]
    public void Equals_NotEqualValue1Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(2)));

    [Fact]
    public void Equals_EqualValue2Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo").Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo")));

    [Fact]
    public void Equals_NotEqualValue2Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo").Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Bar")));

    [Fact]
    public void Equals_EqualValue3Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday)));

    [Fact]
    public void Equals_NotEqualValue3Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Monday)));

    [Fact]
    public void Equals_EqualValue4Passed_ReturnsTrue()
    {
        var person = new Person();
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(person).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(person)));
    }

    [Fact]
    public void Equals_NotEqualValue4Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new Person { Name = "A" }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new Person { Name = "B" })));

    [Fact]
    public void Equals_EqualValue5Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue)));

    [Fact]
    public void Equals_NotEqualValue5Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MaxValue)));

    [Fact]
    public void Equals_EqualValue6Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true)));

    [Fact]
    public void Equals_NotEqualValue6Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(false)));

    [Fact]
    public void Equals_EqualValue7Passed_ReturnsTrue() =>
        Assert.True(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue)));

    [Fact]
    public void Equals_NotEqualValue7Passed_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MaxValue)));

    [Fact]
    public void Equals_MixedTypes_Value1EqualValue2EqualValue3EqualValue4EqualValue5EqualValue6EqualValue7NotEqual_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MaxValue })));

    [Fact]
    public void Equals_MixedTypes_Value1EqualValue2EqualValue3EqualValue4EqualValue5EqualValue6NotEqualValue7Equal_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, false, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_Value1EqualValue2EqualValue3EqualValue4EqualValue5NotEqualValue6EqualValue7Equal_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MaxValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_Value1EqualValue2EqualValue3EqualValue4NotEqualValue5EqualValue6EqualValue7Equal_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person { Name = "Schema" }, DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_Value1EqualValue2EqualValue3NotEqualValue4EqualValue5EqualValue6EqualValue7Equal_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Wednesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_Value1EqualValue2NotEqualValue3EqualValue4EqualValue5EqualValue6EqualValue7Equal_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Bar", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_Value1NotEqualValue2EqualValue3EqualValue4EqualValue5EqualValue6EqualValue7Equal_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 1, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue7_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue6_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue5_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue4_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue3_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue2_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_ThisMissingValue1_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue7_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue6_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue5_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue4_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue3_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue2_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void Equals_MixedTypes_OtherMissingValue1_ReturnsFalse() =>
        Assert.False(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { 0, "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue }).Equals(new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(new object[] { "Foo", DayOfWeek.Tuesday, new Person(), DateTime.MinValue, true, TimeSpan.MinValue })));

    [Fact]
    public void GetHashCode_Value1Passed_ReturnsMatchingHashCode() =>
        Assert.Equal(
            CombineHashCodes(CombineHashCodes(CombineHashCodes(CombineHashCodes(CombineHashCodes(CombineHashCodes(1.GetHashCode(), 0), 0), 0), 0), 0), 0),
            new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(1).GetHashCode());

    [Fact]
    public void GetHashCode_Value2Passed_ReturnsMatchingHashCode() =>
        Assert.Equal(
            CombineHashCodes(CombineHashCodes(CombineHashCodes(CombineHashCodes(CombineHashCodes("Foo".GetHashCode(
#if !NET48
                StringComparison.Ordinal
#endif
            ), 0), 0), 0), 0), 0),
            new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>("Foo").GetHashCode());

    [Fact]
    public void GetHashCode_Value3Passed_ReturnsMatchingHashCode() =>
        Assert.Equal(
            CombineHashCodes(CombineHashCodes(CombineHashCodes(CombineHashCodes(DayOfWeek.Friday.GetHashCode(), 0), 0), 0), 0),
            new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DayOfWeek.Friday).GetHashCode());

    [Fact]
    public void GetHashCode_Value4Passed_ReturnsMatchingHashCode()
    {
        var person = new Person();
        Assert.Equal(
            CombineHashCodes(CombineHashCodes(CombineHashCodes(person.GetHashCode(), 0), 0), 0),
            new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(person).GetHashCode());
    }

    [Fact]
    public void GetHashCode_Value5Passed_ReturnsMatchingHashCode() =>
        Assert.Equal(
            CombineHashCodes(CombineHashCodes(DateTime.MinValue.GetHashCode(), 0), 0),
            new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(DateTime.MinValue).GetHashCode());

    [Fact]
    public void GetHashCode_Value6Passed_ReturnsMatchingHashCode() =>
        Assert.Equal(
            CombineHashCodes(true.GetHashCode(), 0),
            new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(true).GetHashCode());

    [Fact]
    public void GetHashCode_Value7Passed_ReturnsMatchingHashCode() =>
        Assert.Equal(
            TimeSpan.MinValue.GetHashCode(),
            new Values<int, string, DayOfWeek, Person, DateTime, bool, TimeSpan>(TimeSpan.MinValue).GetHashCode());

    private static int CombineHashCodes(int h1, int h2) => ((h1 << 5) + h1) ^ h2;
}
