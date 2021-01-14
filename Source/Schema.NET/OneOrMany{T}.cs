namespace Schema.NET
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A single or list of values.
    /// </summary>
    /// <typeparam name="T">The type of the values.</typeparam>
    /// <seealso cref="ICollection{T}" />
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public readonly struct OneOrMany<T>
        : IReadOnlyCollection<T>, IEnumerable<T>, IValues, IEquatable<OneOrMany<T>>
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        private readonly T[] collection;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="item">The single item value.</param>
        public OneOrMany(T item)
        {
            if (item is null || (item is string itemAsString && string.IsNullOrWhiteSpace(itemAsString)))
            {
                this.collection = null;
                this.HasOne = false;
            }
            else
            {
                this.collection = new[] { item };
                this.HasOne = true;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="span">The span of values.</param>
        public OneOrMany(ReadOnlySpan<T> span)
        {
            if (!span.IsEmpty)
            {
                var items = new T[span.Length];
                var index = 0;

                if (typeof(T) == typeof(string))
                {
                    for (var i = 0; i < span.Length; i++)
                    {
                        var item = span[i];
                        if (!string.IsNullOrWhiteSpace(item as string))
                        {
                            items[index] = item;
                            index++;
                        }
                    }
                }
                else
                {
                    for (var i = 0; i < span.Length; i++)
                    {
                        var item = span[i];
                        if (item is not null)
                        {
                            items[index] = item;
                            index++;
                        }
                    }
                }

                if (index > 0)
                {
                    if (index == span.Length)
                    {
                        this.collection = items;
                    }
                    else
                    {
                        this.collection = new T[index];
                        Array.Copy(items, 0, this.collection, 0, index);
                    }

                    this.HasOne = index == 1;
                    return;
                }
            }

            this.collection = null;
            this.HasOne = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="array">The array of values.</param>
        public OneOrMany(params T[] array)
            : this(array.AsSpan())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="collection">The collection of values.</param>
        public OneOrMany(IEnumerable<T> collection)
            : this(collection.ToArray().AsSpan())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="collection">The list of values.</param>
        public OneOrMany(IEnumerable<object> collection)
            : this(collection.Cast<T>().ToArray().AsSpan())
        {
        }

        /// <summary>
        /// Gets the number of elements contained in the <see cref="OneOrMany{T}"/>.
        /// </summary>
        public int Count => this.collection?.Length ?? 0;

        /// <summary>
        /// Gets a value indicating whether this instance has a single item value.
        /// </summary>
        /// <value><c>true</c> if this instance has a single item value; otherwise, <c>false</c>.</value>
        public bool HasOne { get; }

        /// <summary>
        /// Gets a value indicating whether this instance has more than one value.
        /// </summary>
        /// <value><c>true</c> if this instance has more than one value; otherwise, <c>false</c>.</value>
        public bool HasMany => this.collection?.Length > 1;

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T"/> to <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator OneOrMany<T>(T item) => new OneOrMany<T>(item);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T[]"/> to <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <param name="array">The array of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator OneOrMany<T>(T[] array) => new OneOrMany<T>(array);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T}"/> to <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator OneOrMany<T>(List<T> list) => new OneOrMany<T>(list);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="OneOrMany{T}"/> to <typeparamref name="T"/>.
        /// </summary>
        /// <param name="oneOrMany">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator T(OneOrMany<T> oneOrMany) => oneOrMany.FirstOrDefault();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="OneOrMany{T}"/> to <typeparamref name="T[]"/>.
        /// </summary>
        /// <param name="oneOrMany">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator T[](OneOrMany<T> oneOrMany) => oneOrMany.ToArray();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="OneOrMany{T}"/> to <see cref="List{T}"/>.
        /// </summary>
        /// <param name="oneOrMany">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator List<T>(OneOrMany<T> oneOrMany) => oneOrMany.ToList();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(OneOrMany<T> left, OneOrMany<T> right) => left.Equals(right);

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(OneOrMany<T> left, OneOrMany<T> right) => !(left == right);

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <returns>An enumerator for the <see cref="OneOrMany{T}"/>.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            if (this.collection is not null)
            {
                for (var i = 0; i < this.collection.Length; i++)
                {
                    yield return this.collection[i];
                }
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <returns>An enumerator for the <see cref="OneOrMany{T}"/>.</returns>
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        /// <summary>
        /// Creates an array from <see cref="OneOrMany{T}" />.
        /// </summary>
        /// <returns>An array containing all the elements.</returns>
        public T[] ToArray()
        {
            if (this.HasOne)
            {
                return new[] { this.collection[0] };
            }
            else if (this.HasMany)
            {
                var result = new T[this.collection.Length];
                Array.Copy(this.collection, 0, result, 0, this.collection.Length);
                return result;
            }
            else
            {
#if NETSTANDARD1_1
                return new T[0];
#else
                return Array.Empty<T>();
#endif
            }
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(OneOrMany<T> other)
        {
            if (!this.HasOne && !other.HasOne && !this.HasMany && !other.HasMany)
            {
                return true;
            }
            else if (this.HasOne && other.HasOne)
            {
                return this.collection[0].Equals(other.collection[0]);
            }
            else if (this.HasMany && other.HasMany)
            {
                if (this.collection.Length != other.collection.Length)
                {
                    return false;
                }

                for (var i = 0; i < this.collection.Length; i++)
                {
                    if (!EqualityComparer<T>.Default.Equals(this.collection[i], other.collection[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj) => obj is OneOrMany<T> oneOrMany && this.Equals(oneOrMany);

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode() => HashCode.OfEach(this.collection);
    }
}
