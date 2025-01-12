namespace Schema.NET;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// A single or list of values which can be any of the specified types.
/// </summary>
/// <typeparam name="T1">The first type the values can take.</typeparam>
/// <typeparam name="T2">The second type the values can take.</typeparam>
/// <typeparam name="T3">The third type the values can take.</typeparam>
/// <typeparam name="T4">The fourth type the values can take.</typeparam>
/// <typeparam name="T5">The fifth type the values can take.</typeparam>
#pragma warning disable CA1710 // Identifiers should have correct suffix.
public readonly struct Values<T1, T2, T3, T4, T5>
#pragma warning restore CA1710 // Identifiers should have correct suffix.
    : IReadOnlyCollection<object?>, IValues, IEquatable<Values<T1, T2, T3, T4, T5>>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4,T5}"/> struct.
    /// </summary>
    /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
    public Values(OneOrMany<T1> value)
    {
        this.Value1 = value;
        this.Value2 = default;
        this.Value3 = default;
        this.Value4 = default;
        this.Value5 = default;
        this.HasValue1 = value.Count > 0;
        this.HasValue2 = false;
        this.HasValue3 = false;
        this.HasValue4 = false;
        this.HasValue5 = false;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4,T5}"/> struct.
    /// </summary>
    /// <param name="value">The value of type <typeparamref name="T2"/>.</param>
    public Values(OneOrMany<T2> value)
    {
        this.Value1 = default;
        this.Value2 = value;
        this.Value3 = default;
        this.Value4 = default;
        this.Value5 = default;
        this.HasValue1 = false;
        this.HasValue2 = value.Count > 0;
        this.HasValue3 = false;
        this.HasValue4 = false;
        this.HasValue5 = false;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4,T5}"/> struct.
    /// </summary>
    /// <param name="value">The value of type <typeparamref name="T3"/>.</param>
    public Values(OneOrMany<T3> value)
    {
        this.Value1 = default;
        this.Value2 = default;
        this.Value3 = value;
        this.Value4 = default;
        this.Value5 = default;
        this.HasValue1 = false;
        this.HasValue2 = false;
        this.HasValue3 = value.Count > 0;
        this.HasValue4 = false;
        this.HasValue5 = false;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4,T5}"/> struct.
    /// </summary>
    /// <param name="value">The value of type <typeparamref name="T4"/>.</param>
    public Values(OneOrMany<T4> value)
    {
        this.Value1 = default;
        this.Value2 = default;
        this.Value3 = default;
        this.Value4 = value;
        this.Value5 = default;
        this.HasValue1 = false;
        this.HasValue2 = false;
        this.HasValue3 = false;
        this.HasValue4 = value.Count > 0;
        this.HasValue5 = false;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4,T5}"/> struct.
    /// </summary>
    /// <param name="value">The value of type <typeparamref name="T4"/>.</param>
    public Values(OneOrMany<T5> value)
    {
        this.Value1 = default;
        this.Value2 = default;
        this.Value3 = default;
        this.Value4 = default;
        this.Value5 = value;
        this.HasValue1 = false;
        this.HasValue2 = false;
        this.HasValue3 = false;
        this.HasValue4 = false;
        this.HasValue5 = value.Count > 0;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4,T5}"/> struct.
    /// </summary>
    /// <param name="items">The items.</param>
    public Values(params object?[] items)
        : this(items.AsEnumerable())
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4,T5}"/> struct.
    /// </summary>
    /// <param name="items">The items.</param>
    public Values(IEnumerable<object?> items)
    {
#if NET6_0_OR_GREATER
        ArgumentNullException.ThrowIfNull(items);
#else
        if (items is null)
        {
            throw new ArgumentNullException(nameof(items));
        }
#endif

        List<T1>? items1 = null;
        List<T2>? items2 = null;
        List<T3>? items3 = null;
        List<T4>? items4 = null;
        List<T5>? items5 = null;

        foreach (var item in items)
        {
            if (item is T5 itemT5)
            {
                items5 ??= [];
                items5.Add(itemT5);
            }
            else if (item is T4 itemT4)
            {
                items4 ??= [];
                items4.Add(itemT4);
            }
            else if (item is T3 itemT3)
            {
                items3 ??= [];
                items3.Add(itemT3);
            }
            else if (item is T2 itemT2)
            {
                items2 ??= [];
                items2.Add(itemT2);
            }
            else if (item is T1 itemT1)
            {
                items1 ??= [];
                items1.Add(itemT1);
            }
        }

        this.Value1 = items1 == null ? default : (OneOrMany<T1>)items1!;
        this.Value2 = items2 == null ? default : (OneOrMany<T2>)items2!;
        this.Value3 = items3 == null ? default : (OneOrMany<T3>)items3!;
        this.Value4 = items4 == null ? default : (OneOrMany<T4>)items4!;
        this.Value5 = items5 == null ? default : (OneOrMany<T5>)items5!;

        this.HasValue1 = this.Value1.Count > 0;
        this.HasValue2 = this.Value2.Count > 0;
        this.HasValue3 = this.Value3.Count > 0;
        this.HasValue4 = this.Value4.Count > 0;
        this.HasValue5 = this.Value5.Count > 0;
    }

    /// <summary>
    /// Gets the number of elements contained in the <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    public int Count => this.Value1.Count + this.Value2.Count + this.Value3.Count + this.Value4.Count + this.Value5.Count;

    /// <summary>
    /// Gets a value indicating whether this instance has a value.
    /// </summary>
    public bool HasValue => this.HasValue1 || this.HasValue2 || this.HasValue3 || this.HasValue4 || this.HasValue5;

    /// <summary>
    /// Gets a value indicating whether the value of type <typeparamref name="T1" /> has a value.
    /// </summary>
    public bool HasValue1 { get; }

    /// <summary>
    /// Gets a value indicating whether the value of type <typeparamref name="T2" /> has a value.
    /// </summary>
    public bool HasValue2 { get; }

    /// <summary>
    /// Gets a value indicating whether the value of type <typeparamref name="T3" /> has a value.
    /// </summary>
    public bool HasValue3 { get; }

    /// <summary>
    /// Gets a value indicating whether the value of type <typeparamref name="T4" /> has a value.
    /// </summary>
    public bool HasValue4 { get; }

    /// <summary>
    /// Gets a value indicating whether the value of type <typeparamref name="T5" /> has a value.
    /// </summary>
    public bool HasValue5 { get; }

    /// <summary>
    /// Gets the value of type <typeparamref name="T1" />.
    /// </summary>
    public OneOrMany<T1> Value1 { get; }

    /// <summary>
    /// Gets the value of type <typeparamref name="T2" />.
    /// </summary>
    public OneOrMany<T2> Value2 { get; }

    /// <summary>
    /// Gets the value of type <typeparamref name="T3" />.
    /// </summary>
    public OneOrMany<T3> Value3 { get; }

    /// <summary>
    /// Gets the value of type <typeparamref name="T4" />.
    /// </summary>
    public OneOrMany<T4> Value4 { get; }

    /// <summary>
    /// Gets the value of type <typeparamref name="T5" />.
    /// </summary>
    public OneOrMany<T5> Value5 { get; }

#pragma warning disable CA2225 // Operator overloads have named alternates
#pragma warning disable CA1002 // Do not expose generic lists
    /// <summary>
    /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="item">The single item value.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(T1? item) => new(item);

    /// <summary>
    /// Performs an implicit conversion from <typeparamref name="T2"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="item">The single item value.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(T2? item) => new(item);

    /// <summary>
    /// Performs an implicit conversion from <typeparamref name="T3"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="item">The single item value.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(T3? item) => new(item);

    /// <summary>
    /// Performs an implicit conversion from <typeparamref name="T4"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="item">The single item value.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(T4? item) => new(item);

    /// <summary>
    /// Performs an implicit conversion from <typeparamref name="T5"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="item">The single item value.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(T5? item) => new(item);

    /// <summary>
    /// Performs an implicit conversion from <typeparamref name="T1[]"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="array">The array of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(T1?[] array) => new(array);

    /// <summary>
    /// Performs an implicit conversion from <typeparamref name="T2[]"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="array">The array of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(T2?[] array) => new(array);

    /// <summary>
    /// Performs an implicit conversion from <typeparamref name="T3[]"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="array">The array of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(T3?[] array) => new(array);

    /// <summary>
    /// Performs an implicit conversion from <typeparamref name="T4[]"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="array">The array of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(T4?[] array) => new(array);

    /// <summary>
    /// Performs an implicit conversion from <typeparamref name="T5[]"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="array">The array of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(T5?[] array) => new(array);

    /// <summary>
    /// Performs an implicit conversion from <see cref="List{T1}"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="list">The list of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(List<T1?> list) => new(list);

    /// <summary>
    /// Performs an implicit conversion from <see cref="List{T2}"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="list">The list of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(List<T2?> list) => new(list);

    /// <summary>
    /// Performs an implicit conversion from <see cref="List{T3}"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="list">The list of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(List<T3?> list) => new(list);

    /// <summary>
    /// Performs an implicit conversion from <see cref="List{T4}"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="list">The list of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(List<T4?> list) => new(list);

    /// <summary>
    /// Performs an implicit conversion from <see cref="List{T5}"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="list">The list of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(List<T5?> list) => new(list);

    /// <summary>
    /// Performs an implicit conversion from <see cref="object"/> array to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="array">The array of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(object?[] array) => new(array);

    /// <summary>
    /// Performs an implicit conversion from <see cref="List{Object}"/> to <see cref="Values{T1,T2,T3,T4,T5}"/>.
    /// </summary>
    /// <param name="list">The list of values.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Values<T1, T2, T3, T4, T5>(List<object?> list) => new(list);

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to the first item of type <typeparamref name="T1"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator T1?(Values<T1, T2, T3, T4, T5> values) => values.Value1.FirstOrDefault();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to the first item of type <typeparamref name="T2"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator T2?(Values<T1, T2, T3, T4, T5> values) => values.Value2.FirstOrDefault();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to the first item of type <typeparamref name="T3"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator T3?(Values<T1, T2, T3, T4, T5> values) => values.Value3.FirstOrDefault();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to the first item of type <typeparamref name="T4"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator T4?(Values<T1, T2, T3, T4, T5> values) => values.Value4.FirstOrDefault();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to the first item of type <typeparamref name="T5"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator T5?(Values<T1, T2, T3, T4, T5> values) => values.Value5.FirstOrDefault();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to an array of <typeparamref name="T1"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator T1[](Values<T1, T2, T3, T4, T5> values) => values.Value1.ToArray();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to <see cref="List{T1}"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator List<T1>(Values<T1, T2, T3, T4, T5> values) => values.Value1.ToList();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to an array of <typeparamref name="T2"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator T2[](Values<T1, T2, T3, T4, T5> values) => values.Value2.ToArray();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to <see cref="List{T2}"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator List<T2>(Values<T1, T2, T3, T4, T5> values) => values.Value2.ToList();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to an array of <typeparamref name="T3"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator T3[](Values<T1, T2, T3, T4, T5> values) => values.Value3.ToArray();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to <see cref="List{T3}"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator List<T3>(Values<T1, T2, T3, T4, T5> values) => values.Value3.ToList();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to an array of <typeparamref name="T4"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator T4[](Values<T1, T2, T3, T4, T5> values) => values.Value4.ToArray();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to <see cref="List{T4}"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator List<T4>(Values<T1, T2, T3, T4, T5> values) => values.Value4.ToList();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to an array of <typeparamref name="T5"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator T5[](Values<T1, T2, T3, T4, T5> values) => values.Value5.ToArray();

    /// <summary>
    /// Performs an implicit conversion from <see cref="Values{T1,T2,T3,T4,T5}"/> to <see cref="List{T5}"/>.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns>
    /// The result of the conversion.
    /// </returns>
    public static implicit operator List<T5>(Values<T1, T2, T3, T4, T5> values) => values.Value5.ToList();
#pragma warning restore CA1002 // Do not expose generic lists
#pragma warning restore CA2225 // Operator overloads have named alternates

    /// <summary>
    /// Implements the operator ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator ==(Values<T1, T2, T3, T4, T5> left, Values<T1, T2, T3, T4, T5> right) => left.Equals(right);

    /// <summary>
    /// Implements the operator !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator !=(Values<T1, T2, T3, T4, T5> left, Values<T1, T2, T3, T4, T5> right) => !(left == right);

    /// <summary>Deconstructs the specified items.</summary>
    /// <param name="items1">The items from value 1.</param>
    /// <param name="items2">The items from value 2.</param>
    /// <param name="items3">The items from value 3.</param>
    /// <param name="items4">The items from value 4.</param>
    /// <param name="items5">The items from value 5.</param>
    public void Deconstruct(out IEnumerable<T1> items1, out IEnumerable<T2> items2, out IEnumerable<T3> items3, out IEnumerable<T4> items4, out IEnumerable<T5> items5)
    {
        items1 = this.Value1;
        items2 = this.Value2;
        items3 = this.Value3;
        items4 = this.Value4;
        items5 = this.Value5;
    }

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>An enumerator that can be used to iterate through the collection.</returns>
    public IEnumerator<object?> GetEnumerator()
    {
        if (this.HasValue1)
        {
            foreach (var item1 in this.Value1)
            {
                yield return item1;
            }
        }

        if (this.HasValue2)
        {
            foreach (var item2 in this.Value2)
            {
                yield return item2;
            }
        }

        if (this.HasValue3)
        {
            foreach (var item3 in this.Value3)
            {
                yield return item3;
            }
        }

        if (this.HasValue4)
        {
            foreach (var item4 in this.Value4)
            {
                yield return item4;
            }
        }

        if (this.HasValue5)
        {
            foreach (var item5 in this.Value5)
            {
                yield return item5;
            }
        }
    }

    /// <summary>Returns an enumerator that iterates through a collection.</summary>
    /// <returns>An <see cref="IEnumerator"/> object that can be used to iterate through the collection.</returns>
    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
    /// </returns>
    public bool Equals(Values<T1, T2, T3, T4, T5> other)
    {
        if (!other.HasValue && !this.HasValue)
        {
            return true;
        }

        return this.Value1.Equals(other.Value1) &&
            this.Value2.Equals(other.Value2) &&
            this.Value3.Equals(other.Value3) &&
            this.Value4.Equals(other.Value4) &&
            this.Value5.Equals(other.Value5);
    }

    /// <summary>
    /// Determines whether the specified <see cref="object" />, is equal to this instance.
    /// </summary>
    /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
    /// <returns>
    /// <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
    /// </returns>
    public override bool Equals(object? obj) => obj is Values<T1, T2, T3, T4, T5> values && this.Equals(values);

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>
    /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
    /// </returns>
    public override int GetHashCode() =>
        HashCode.Of(this.Value1).And(this.Value2).And(this.Value3).And(this.Value4).And(this.Value5);
}
