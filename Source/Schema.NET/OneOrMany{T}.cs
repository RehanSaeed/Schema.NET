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
    public struct OneOrMany<T>
        : IReadOnlyCollection<T>, IEnumerable<T>, IValues, IEquatable<OneOrMany<T>>
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        private readonly List<T> collection;
        private readonly T item;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="item">The single item value.</param>
        public OneOrMany(T item)
        {
            this.collection = null;
            this.item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="array">The array of values.</param>
        public OneOrMany(params T[] array)
            : this(array == null ? null : new List<T>(array))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="collection">The collection of values.</param>
        public OneOrMany(IEnumerable<T> collection)
            : this(collection == null ? null : new List<T>(collection))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="list">The list of values.</param>
        public OneOrMany(List<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (list.Count == 1)
            {
                this.collection = null;
                this.item = list[0];
            }
            else
            {
                this.collection = list;
                this.item = default;
            }
        }

        /// <summary>
        /// Gets the number of elements contained in the <see cref="OneOrMany{T}"/>.
        /// </summary>
        public int Count
        {
            get
            {
                if (this.HasOne)
                {
                    return 1;
                }
                else if (this.HasMany)
                {
                    return this.collection.Count;
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has a single item value.
        /// </summary>
        /// <value><c>true</c> if this instance has a single item value; otherwise, <c>false</c>.</value>
        public bool HasOne => this.collection == null && this.item != null;

        /// <summary>
        /// Gets a value indicating whether this instance has more than one value.
        /// </summary>
        /// <value><c>true</c> if this instance has more than one value; otherwise, <c>false</c>.</value>
        public bool HasMany => this.collection != null;

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
            if (this.HasMany)
            {
                foreach (var item in this.collection)
                {
                    yield return item;
                }
            }
            else if (this.HasOne)
            {
                yield return this.item;
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <returns>An enumerator for the <see cref="OneOrMany{T}"/>.</returns>
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

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
                return this.item.Equals(other.item);
            }
            else if (this.HasMany && other.HasMany)
            {
                if (this.collection.Count != other.collection.Count)
                {
                    return false;
                }

                for (var i = 0; i < this.collection.Count; i++)
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
        public override bool Equals(object obj) => obj is OneOrMany<T> ? this.Equals((OneOrMany<T>)obj) : false;

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            if (this.HasOne)
            {
                return HashCode.Of(this.item);
            }
            else if (this.HasMany)
            {
                return HashCode.OfEach(this.collection);
            }

            return 0;
        }
    }
}
