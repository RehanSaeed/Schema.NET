namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class OneOrManyTest
    {
        [Fact]
        public void Count_DefaultStructConstructor_ReturnsOne() => Assert.Single(default(OneOrMany<int>));

        [Fact]
        public void Count_DefaultClassConstructor_ReturnsZero() => Assert.Empty(default(OneOrMany<string>));

        [Fact]
        public void Count_OneItem_ReturnsOne() => Assert.Single(new OneOrMany<int>(1));

        [Fact]
        public void Count_Array_ReturnsTwo() => Assert.Equal(2, new OneOrMany<int>(1, 2).Count);

        [Fact]
        public void Count_Enumerable_ReturnsTwo() =>
            Assert.Equal(2, new OneOrMany<int>(new List<int>() { 1, 2 }).Count);

        [Fact]
        public void HasOne_DefaultStructConstructor_ReturnsTrue() => Assert.True(default(OneOrMany<int>).HasOne);

        [Fact]
        public void HasOne_DefaultClassConstructor_ReturnsFalse() => Assert.False(default(OneOrMany<string>).HasOne);

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
        public void Value_DefaultStructConstructor_ReturnsZero()
        {
            var item = Assert.Single(((IValues)default(OneOrMany<int>)).Cast<object>());
            Assert.Equal(0, item);
        }

        [Fact]
        public void Value_DefaultClassConstructor_ReturnsNull() =>
            Assert.Empty(((IValues)default(OneOrMany<string>)).Cast<object>());

        [Fact]
        public void Value_OneItem_ReturnsOne()
        {
            var item = Assert.Single(((IValues)new OneOrMany<int>(1)).Cast<object>());
            Assert.Equal(1, item);
        }

        [Fact]
        public void Value_Array_ReturnsTwo() =>
            Assert.Equal(new List<object>() { 1, 2 }, ((IValues)new OneOrMany<int>(1, 2)).Cast<object>());

        [Fact]
        public void Value_Enumerable_ReturnsTwo() =>
            Assert.Equal(new List<object>() { 1, 2 }, ((IValues)new OneOrMany<int>(new List<int>() { 1, 2 })).Cast<object>());

        [Fact]
        public void ImplicitConversionOperator_Item_HasOneItem()
        {
            OneOrMany<int> oneOrMany = 1;
            Assert.Equal(new List<object>() { 1 }, ((IValues)oneOrMany).Cast<object>());
        }

        [Fact]
        public void ImplicitConversionOperator_Array_HasTwoItems()
        {
            OneOrMany<int> oneOrMany = new int[] { 1, 2 };
            Assert.Equal(new List<object>() { 1, 2 }, ((IValues)oneOrMany).Cast<object>());
        }

        [Fact]
        public void ImplicitConversionOperator_List_HasTwoItems()
        {
            OneOrMany<int> oneOrMany = new List<int>() { 1, 2 };
            Assert.Equal(new List<object>() { 1, 2 }, ((IValues)oneOrMany).Cast<object>());
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
        public void GetEnumerator_NoItems_ReturnsEmptyCllection() =>
            Assert.Equal(new List<string>(), default(OneOrMany<string>).ToList());

        [Fact]
        public void GetEnumerator_OneItem_ReturnsOneItem() =>
            Assert.Equal(new List<int>() { 1 }, new OneOrMany<int>(1).ToList());

        [Fact]
        public void GetEnumerator_TwoItems_ReturnsTwoItems() =>
            Assert.Equal(new List<int>() { 1, 2 }, new OneOrMany<int>(1, 2).ToList());

        [Fact]
        public void Equals_Null_ReturnsFalse() =>
            Assert.False(new OneOrMany<int>(1).Equals((object)null));

        [Fact]
        public void Equals_IsEqualOneItem_ReturnsTrue() =>
            Assert.True(new OneOrMany<int>(1).Equals(new OneOrMany<int>(1)));

        [Fact]
        public void Equals_IsEqualTwoItems_ReturnsTrue() =>
            Assert.True(new OneOrMany<int>(1, 2).Equals(new OneOrMany<int>(1, 2)));

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
            Assert.Equal(NET.HashCode.OfEach(new List<int>() { 1, 2 }), new OneOrMany<int>(1, 2).GetHashCode());
    }
}
