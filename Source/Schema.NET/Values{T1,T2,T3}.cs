namespace Schema.NET
{
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
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public readonly struct Values<T1, T2, T3>
        : IReadOnlyCollection<object>, IEnumerable<object>, IValues, IEquatable<Values<T1, T2, T3>>
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
        public Values(OneOrMany<T1> value)
        {
            this.Value1 = value;
            this.Value2 = default;
            this.Value3 = default;
            this.HasValue1 = value.Count > 0;
            this.HasValue2 = false;
            this.HasValue3 = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T2"/>.</param>
        public Values(OneOrMany<T2> value)
        {
            this.Value1 = default;
            this.Value2 = value;
            this.Value3 = default;
            this.HasValue1 = false;
            this.HasValue2 = value.Count > 0;
            this.HasValue3 = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T3"/>.</param>
        public Values(OneOrMany<T3> value)
        {
            this.Value1 = default;
            this.Value2 = default;
            this.Value3 = value;
            this.HasValue1 = false;
            this.HasValue2 = false;
            this.HasValue3 = value.Count > 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="items">The items.</param>
        public Values(params object[] items)
            : this(items.AsEnumerable())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="items">The items.</param>
        public Values(IEnumerable<object> items)
        {
            if (items is null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            List<T1> items1 = null;
            List<T2> items2 = null;
            List<T3> items3 = null;

            foreach (var item in items)
            {
                if (item is T3 itemT3)
                {
                    if (items3 == null)
                    {
                        items3 = new List<T3>();
                    }

                    items3.Add(itemT3);
                }
                else if (item is T2 itemT2)
                {
                    if (items2 == null)
                    {
                        items2 = new List<T2>();
                    }

                    items2.Add(itemT2);
                }
                else if (item is T1 itemT1)
                {
                    if (items1 == null)
                    {
                        items1 = new List<T1>();
                    }

                    items1.Add(itemT1);
                }
            }

            this.HasValue1 = items1?.Count > 0;
            this.HasValue2 = items2?.Count > 0;
            this.HasValue3 = items3?.Count > 0;

            this.Value1 = items1 == null ? default : (OneOrMany<T1>)items1;
            this.Value2 = items2 == null ? default : (OneOrMany<T2>)items2;
            this.Value3 = items3 == null ? default : (OneOrMany<T3>)items3;
        }

        /// <summary>
        /// Gets the number of elements contained in the <see cref="Values{T1,T2,T3}"/>.
        /// </summary>
        public int Count => this.Value1.Count + this.Value2.Count + this.Value3.Count;

        /// <summary>
        /// Gets a value indicating whether this instance has a value.
        /// </summary>
        public bool HasValue => this.HasValue1 || this.HasValue2 || this.HasValue3;

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
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(T1 item) => new Values<T1, T2, T3>(item);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T2"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(T2 item) => new Values<T1, T2, T3>(item);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T3"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(T3 item) => new Values<T1, T2, T3>(item);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1[]"/> to <see cref="Values{T1,T2,T3}"/>.
        /// </summary>
        /// <param name="array">The array of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(T1[] array) => new Values<T1, T2, T3>(array);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T2[]"/> to <see cref="Values{T1,T2,T3}"/>.
        /// </summary>
        /// <param name="array">The array of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(T2[] array) => new Values<T1, T2, T3>(array);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T3[]"/> to <see cref="Values{T1,T2,T3}"/>.
        /// </summary>
        /// <param name="array">The array of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(T3[] array) => new Values<T1, T2, T3>(array);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T1}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(List<T1> list) => new Values<T1, T2, T3>(list);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T2}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(List<T2> list) => new Values<T1, T2, T3>(list);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T3}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(List<T3> list) => new Values<T1, T2, T3>(list);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="object"/> array to <see cref="Values{T1,T2,T3}"/>.
        /// </summary>
        /// <param name="array">The array of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(object[] array) => new Values<T1, T2, T3>(array);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{Object}"/> to <see cref="Values{T1,T2,T3}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2, T3>(List<object> list) => new Values<T1, T2, T3>(list);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2, T3}"/> to the first item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator T1(Values<T1, T2, T3> values) => values.Value1.FirstOrDefault();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2, T3}"/> to the first item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator T2(Values<T1, T2, T3> values) => values.Value2.FirstOrDefault();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2, T3}"/> to the first item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator T3(Values<T1, T2, T3> values) => values.Value3.FirstOrDefault();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2, T3}"/> to an array of <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator T1[](Values<T1, T2, T3> values) => values.Value1.ToArray();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2, T3}"/> to <see cref="List{T1}"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator List<T1>(Values<T1, T2, T3> values) => values.Value1.ToList();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2, T3}"/> to an array of <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator T2[](Values<T1, T2, T3> values) => values.Value2.ToArray();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2, T3}"/> to <see cref="List{T2}"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator List<T2>(Values<T1, T2, T3> values) => values.Value2.ToList();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2, T3}"/> to an array of <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator T3[](Values<T1, T2, T3> values) => values.Value3.ToArray();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2, T3}"/> to <see cref="List{T3}"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator List<T3>(Values<T1, T2, T3> values) => values.Value3.ToList();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(Values<T1, T2, T3> left, Values<T1, T2, T3> right) => left.Equals(right);

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(Values<T1, T2, T3> left, Values<T1, T2, T3> right) => !(left == right);

        /// <summary>Deconstructs the specified items.</summary>
        /// <param name="items1">The items from value 1.</param>
        /// <param name="items2">The items from value 2.</param>
        /// <param name="items3">The items from value 3.</param>
        public void Deconstruct(out IEnumerable<T1> items1, out IEnumerable<T2> items2, out IEnumerable<T3> items3)
        {
            items1 = this.Value1;
            items2 = this.Value2;
            items3 = this.Value3;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<object> GetEnumerator()
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
        public bool Equals(Values<T1, T2, T3> other)
        {
            if (!other.HasValue && !this.HasValue)
            {
                return true;
            }

            return this.Value1.Equals(other.Value1) &&
                this.Value2.Equals(other.Value2) &&
                this.Value3.Equals(other.Value3);
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj) => obj is Values<T1, T2, T3> values && this.Equals(values);

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode() => HashCode.Of(this.Value1).And(this.Value2).And(this.Value3);
    }
}
