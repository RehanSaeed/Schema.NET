namespace Schema.NET.Test;

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using HashCode = Schema.NET.HashCode;

public class OneOrManyTest
{
    [Fact]
    public void Constructor_OneItem_HasOneItem()
    {
        var oneOrMany = new OneOrMany<int>(1);
        Assert.True(oneOrMany.HasOne);
        Assert.False(oneOrMany.HasMany);
    }

    [Fact]
    public void Constructor_OneNullItem_HasNoItems()
    {
        var oneOrMany = new OneOrMany<int?>((int?)null);
        Assert.False(oneOrMany.HasOne);
        Assert.False(oneOrMany.HasMany);
    }

    [Fact]
    public void Constructor_ParamsArray_HasManyItems()
    {
        var oneOrMany = new OneOrMany<int>(1, 2);
        Assert.False(oneOrMany.HasOne);
        Assert.True(oneOrMany.HasMany);
    }

    [Fact]
    public void Constructor_Enumerable_HasManyItems()
    {
        var oneOrMany = new OneOrMany<int>(new List<int>() { 1, 2, }.AsEnumerable());
        Assert.False(oneOrMany.HasOne);
        Assert.True(oneOrMany.HasMany);
    }

    [Fact]
    public void Constructor_List_HasManyItems()
    {
        var oneOrMany = new OneOrMany<int>(new List<int>() { 1, 2, });
        Assert.False(oneOrMany.HasOne);
        Assert.True(oneOrMany.HasMany);
    }

    [Fact]
    public void Constructor_NullEnumerable_ThrowsArgumentNullException() =>
        Assert.Throws<ArgumentNullException>(() => new OneOrMany<int>((IEnumerable<int>)null!));

    [Fact]
    public void Constructor_NullList_ThrowsArgumentNullException() =>
        Assert.Throws<ArgumentNullException>(() => new OneOrMany<int>((List<int>)null!));

    [Fact]
    public void Count_DefaultStructConstructor_ReturnsZero() => Assert.Empty(default(OneOrMany<int>));

    [Fact]
    public void Count_DefaultClassConstructor_ReturnsZero() => Assert.Empty(default(OneOrMany<string>)!);

    [Fact]
    public void Count_NullItem_ReturnsZero() => Assert.Empty(new OneOrMany<int?>((int?)null));

    [Fact]
    public void Count_OneItem_ReturnsOne() => Assert.Single(new OneOrMany<int>(1));

    [Fact]
    public void Count_Array_ReturnsTwo() => Assert.Equal(2, new OneOrMany<int>(1, 2).Count);

    [Fact]
    public void Count_Enumerable_ReturnsTwo() =>
        Assert.Equal(2, new OneOrMany<int>(new List<int>() { 1, 2 }).Count);

    [Fact]
    public void HasOne_DefaultStructConstructor_ReturnsFalse() => Assert.False(default(OneOrMany<int>).HasOne);

    [Fact]
    public void HasOne_DefaultClassConstructor_ReturnsFalse() => Assert.False(default(OneOrMany<string>).HasOne);

    [Fact]
    public void HasOne_NullItem_ReturnsFalse() => Assert.False(new OneOrMany<int?>((int?)null).HasOne);

    [Fact]
    public void HasOne_OneItem_ReturnsTrue() => Assert.True(new OneOrMany<int>(1).HasOne);

    [Fact]
    public void HasOne_Array_ReturnsFalse() => Assert.False(new OneOrMany<int>(1, 2).HasOne);

    [Fact]
    public void HasOne_Enumerable_ReturnsFalse() =>
        Assert.False(new OneOrMany<int>(new List<int>() { 1, 2 }).HasOne);

    [Fact]
    public void HasMany_DefaultStructConstructor_ReturnsFalse() => Assert.False(default(OneOrMany<int>).HasMany);

    [Fact]
    public void HasMany_DefaultClassConstructor_ReturnsFalse() => Assert.False(default(OneOrMany<string>).HasMany);

    [Fact]
    public void HasMany_OneItem_ReturnsFalse() => Assert.False(new OneOrMany<int>(1).HasMany);

    [Fact]
    public void HasMany_Array_ReturnsTrue() => Assert.True(new OneOrMany<int>(1, 2).HasMany);

    [Fact]
    public void HasMany_Enumerable_ReturnsTrue() =>
        Assert.True(new OneOrMany<int>(new List<int>() { 1, 2 }).HasMany);

    [Fact]
    public void ImplicitConversionOperator_ToItem_HasOneItem()
    {
        OneOrMany<int> oneOrMany = 1;
        Assert.Equal(new List<object>() { 1 }, oneOrMany.Cast<object>());
    }

    [Fact]
    public void ImplicitConversionOperator_ToArray_HasTwoItems()
    {
        OneOrMany<int> oneOrMany = new int[] { 1, 2 };
        Assert.Equal(new List<object>() { 1, 2 }, oneOrMany.Cast<object>());
    }

    [Fact]
    public void ImplicitConversionOperator_ToList_HasTwoItems()
    {
        OneOrMany<int> oneOrMany = new List<int>() { 1, 2 };
        Assert.Equal(new List<object>() { 1, 2 }, oneOrMany.Cast<object>());
    }

    [Fact]
    public void ImplicitConversionOperator_FromItem_HasOneItem()
    {
        int item = new OneOrMany<int>(1);
        Assert.Equal(1, item);
    }

    [Fact]
    public void ImplicitConversionOperator_FromArray_HasTwoItems()
    {
        int[] items = new OneOrMany<int>(1, 2);
        Assert.Equal(new int[] { 1, 2 }, items);
    }

    [Fact]
    public void ImplicitConversionOperator_FromList_HasTwoItems()
    {
        List<int> items = new OneOrMany<int>(1, 2);
        Assert.Equal(new List<int> { 1, 2 }, items);
    }

    [Fact]
    public void EqualsOperator_IsEqual_ReturnsTrue() =>
        Assert.True(new OneOrMany<int>(1) == new OneOrMany<int>(1));

    [Fact]
    public void EqualsOperator_IsNotEqual_ReturnsFalse() =>
        Assert.False(new OneOrMany<int>(1) == new OneOrMany<int>(2));

    [Fact]
    public void NotEqualsOperator_IsEqual_ReturnsFalse() =>
        Assert.False(new OneOrMany<int>(1) != new OneOrMany<int>(1));

    [Fact]
    public void NotEqualsOperator_IsNotEqual_ReturnsTrue() =>
        Assert.True(new OneOrMany<int>(1) != new OneOrMany<int>(2));

    [Fact]
    public void GetEnumerator_DefaultStructConstructor_ReturnsNull() =>
        Assert.Empty(default(OneOrMany<int>).Cast<object>());

    [Fact]
    public void GetEnumerator_DefaultClassConstructor_ReturnsNull() =>
        Assert.Empty(default(OneOrMany<string>).Cast<object>());

    [Fact]
    public void GetEnumerator_OneItem_ReturnsOne()
    {
        var item = Assert.Single(new OneOrMany<int>(1).Cast<object>());
        Assert.Equal(1, item);
    }

    [Fact]
    public void GetEnumerator_Array_ReturnsTwo() =>
        Assert.Equal(new List<object>() { 1, 2 }, new OneOrMany<int>(1, 2).Cast<object>());

    [Fact]
    public void GetEnumerator_Enumerable_ReturnsTwo() =>
        Assert.Equal(new List<object>() { 1, 2 }, new OneOrMany<int>(new List<int>() { 1, 2 }).Cast<object>());

    [Fact]
    public void GetEnumeratorT_NoItems_ReturnsEmptyCllection() =>
        Assert.Equal(new List<string>(), default(OneOrMany<string>).ToList());

    [Fact]
    public void GetEnumeratorT_OneItem_ReturnsOneItem() =>
        Assert.Equal(new List<int>() { 1 }, new OneOrMany<int>(1).ToList());

    [Fact]
    public void GetEnumeratorT_TwoItems_ReturnsTwoItems() =>
        Assert.Equal(new List<int>() { 1, 2 }, new OneOrMany<int>(1, 2).ToList());

    [Fact]
    public void Equals_Null_ReturnsFalse() =>
        Assert.False(new OneOrMany<int>(1).Equals((object)null!));

    [Fact]
    public void Equals_IsEqualOneItem_ReturnsTrue() =>
        Assert.True(new OneOrMany<int>(1).Equals(new OneOrMany<int>(1)));

    [Fact]
    public void Equals_IsEqualTwoItems_ReturnsTrue() =>
        Assert.True(new OneOrMany<int>(1, 2).Equals(new OneOrMany<int>(1, 2)));

    [Fact]
    public void Equals_CountNotEqual_ReturnsFalse() =>
        Assert.False(new OneOrMany<int>(1, 2).Equals(new OneOrMany<int>(1, 2, 3)));

    [Fact]
    public void Equals_IsNotEqualOneItem_ReturnsFalse() =>
        Assert.False(new OneOrMany<int>(1).Equals(new OneOrMany<int>(2)));

    [Fact]
    public void Equals_IsNotEqualTwoItemsNotInOrder_ReturnsFalse() =>
        Assert.False(new OneOrMany<int>(1, 2).Equals(new OneOrMany<int>(2, 1)));

    [Fact]
    public void GetHashCode_OneItem_HashCodeEqualToSingleItem() =>
        Assert.Equal(1.GetHashCode(), new OneOrMany<int>(1).GetHashCode());

    [Fact]
    public void GetHashCode_TwoItems_HashCodeEqualToTwoItems() =>
        Assert.Equal(HashCode.OfEach(new List<int>() { 1, 2 }), new OneOrMany<int>(1, 2).GetHashCode());

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("  ")]
    public void ToString_NullEmptyOrWhiteSpace_BookOmitsNameProperty(string name)
    {
        var book = new Book() { Name = name };

        var expectedJson = /*lang=json,strict*/
            """
            {"@context":"https://schema.org","@type":"Book"}
            """;
        Assert.Equal(expectedJson, book.ToString());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("  ")]
    public void ToString_NullEmptyOrWhiteSpace_OrganizationOmitsAddressProperty(string address)
    {
        var organization = new Organization() { Address = address };

        var expectedJson = /*lang=json,strict*/
            """
            {"@context":"https://schema.org","@type":"Organization"}
            """;
        Assert.Equal(expectedJson, organization.ToString());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("  ")]
    public void ToString_NullEmptyOrWhiteSpace_BookOmitsNamePropertyFromList(string name)
    {
        var book = new Book() { Name = new List<string> { "Hamlet", name } };

        var expectedJson = /*lang=json,strict*/
            """
            {"@context":"https://schema.org","@type":"Book","name":"Hamlet"}
            """;
        Assert.Equal(expectedJson, book.ToString());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("  ")]
    public void ToString_NullEmptyOrWhiteSpace_BookOmitsNamePropertyFromArray(string name)
    {
        var book = new Book() { Name = new string[] { "Hamlet", name } };

        var expectedJson = /*lang=json,strict*/
            """
            {"@context":"https://schema.org","@type":"Book","name":"Hamlet"}
            """;
        Assert.Equal(expectedJson, book.ToString());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("  ")]
    public void ToString_EmptyOrWhiteSpace_OrganizationOmitsAddressProperty(string address)
    {
        var organization = new Organization() { Address = address };

        var expectedJson = /*lang=json,strict*/
            """
            {"@context":"https://schema.org","@type":"Organization"}
            """;
        Assert.Equal(expectedJson, organization.ToString());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("  ")]
    public void ToString_NullEmptyOrWhiteSpace_OrganizationOmitsNamePropertyFromList(string address)
    {
        var organization = new Organization() { Name = new List<string> { "Cardiff, UK", address } };

        var expectedJson = /*lang=json,strict*/
            """
            {"@context":"https://schema.org","@type":"Organization","name":"Cardiff, UK"}
            """;
        Assert.Equal(expectedJson, organization.ToString());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("  ")]
    public void ToString_NullEmptyOrWhiteSpace_OrganizationOmitsNamePropertyFromArray(string address)
    {
        var organization = new Organization() { Name = new string[] { "Cardiff, UK", address } };

        var expectedJson = /*lang=json,strict*/
            """
            {"@context":"https://schema.org","@type":"Organization","name":"Cardiff, UK"}
            """;
        Assert.Equal(expectedJson, organization.ToString());
    }
}
