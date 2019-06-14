namespace Schema.NET
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A single or list of values.
    /// </summary>
    /// <typeparam name="TInterface">The interface type of the values.</typeparam>
    /// <typeparam name="TImplementation">The implementation type of the values.</typeparam>
    /// <seealso cref="ICollection{TInterface}" />
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public struct OneOrMany<TInterface, TImplementation>
        : IReadOnlyCollection<TInterface>, IEnumerable<TInterface>, IValues, IEquatable<OneOrMany<TInterface, TImplementation>>
#pragma warning restore CA1710 // Identifiers should have correct suffix
        where TImplementation : TInterface
    {
        private readonly List<TInterface> collection;
        private readonly TInterface item;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{TInterface, TImplementation}"/> struct.
        /// </summary>
        /// <param name="item">The single item value.</param>
        public OneOrMany(TInterface item)
        {
            this.collection = null;
            this.item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{TInterface, TImplementation}"/> struct.
        /// </summary>
        /// <param name="array">The array of values.</param>
        public OneOrMany(params TInterface[] array)
            : this(array == null ? null : new List<TInterface>(array))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{TInterface, TImplementation}"/> struct.
        /// </summary>
        /// <param name="collection">The collection of values.</param>
        public OneOrMany(IEnumerable<TInterface> collection)
            : this(collection == null ? null : new List<TInterface>(collection))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{TInterface, TImplementation}"/> struct.
        /// </summary>
        /// <param name="collection">The collection of values.</param>
        public OneOrMany(IEnumerable<TImplementation> collection)
            : this(collection == null ? null : new List<TInterface>(collection.Cast<TInterface>()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{TInterface, TImplementation}"/> struct.
        /// </summary>
        /// <param name="list">The list of values.</param>
        public OneOrMany(List<TInterface> list)
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
        /// Gets the number of elements contained in the <see cref="OneOrMany{TInterface, TImplementation}"/>.
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
        /// Performs an implicit conversion from <typeparamref name="TInterface"/> to <see cref="OneOrMany{TInterface, TImplementation}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator OneOrMany<TInterface, TImplementation>(TInterface item) =>
            item != null && IsStringNullOrWhiteSpace(item) ? default : new OneOrMany<TInterface, TImplementation>(item);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="TInterface[]"/> to <see cref="OneOrMany{TInterface, TImplementation}"/>.
        /// </summary>
        /// <param name="array">The array of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator OneOrMany<TInterface, TImplementation>(TInterface[] array) =>
            new OneOrMany<TInterface, TImplementation>(array?.Where(x => x != null && !IsStringNullOrWhiteSpace(x)));
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T}"/> to <see cref="OneOrMany{TInterface, TImplementation}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator OneOrMany<TInterface, TImplementation>(List<TInterface> list) =>
            new OneOrMany<TInterface, TImplementation>(list?.Where(x => x != null && !IsStringNullOrWhiteSpace(x)));
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="TInterface[]"/> to <see cref="OneOrMany{TInterface, TImplementation}"/>.
        /// </summary>
        /// <param name="array">The array of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator OneOrMany<TInterface, TImplementation>(TImplementation[] array) =>
            new OneOrMany<TInterface, TImplementation>(array?.Where(x => x != null && !IsStringNullOrWhiteSpace(x)));
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T}"/> to <see cref="OneOrMany{TInterface, TImplementation}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator OneOrMany<TInterface, TImplementation>(List<TImplementation> list) =>
            new OneOrMany<TInterface, TImplementation>(list?.Where(x => x != null && !IsStringNullOrWhiteSpace(x)));
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="OneOrMany{TInterface, TImplementation}"/> to <typeparamref name="TInterface"/>.
        /// </summary>
        /// <param name="oneOrMany">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator TInterface(OneOrMany<TInterface, TImplementation> oneOrMany) => oneOrMany.FirstOrDefault();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="OneOrMany{TTInterface, TImplementation}"/> to <typeparamref name="TInterface[]"/>.
        /// </summary>
        /// <param name="oneOrMany">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator TInterface[](OneOrMany<TInterface, TImplementation> oneOrMany) => oneOrMany.ToArray();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="OneOrMany{TInterface, TImplementation}"/> to <see cref="List{TInterface}"/>.
        /// </summary>
        /// <param name="oneOrMany">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator List<TInterface>(OneOrMany<TInterface, TImplementation> oneOrMany) => oneOrMany.ToList();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(OneOrMany<TInterface, TImplementation> left, OneOrMany<TInterface, TImplementation> right) => left.Equals(right);

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(OneOrMany<TInterface, TImplementation> left, OneOrMany<TInterface, TImplementation> right) => !(left == right);

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="OneOrMany{TInterface, TImplementation}"/>.
        /// </summary>
        /// <returns>An enumerator for the <see cref="OneOrMany{TInterface, TImplementation}"/>.</returns>
        public IEnumerator<TInterface> GetEnumerator()
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
        /// Returns an enumerator that iterates through the <see cref="OneOrMany{TInterface, TImplementation}"/>.
        /// </summary>
        /// <returns>An enumerator for the <see cref="OneOrMany{TInterface, TImplementation}"/>.</returns>
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(OneOrMany<TInterface, TImplementation> other)
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
                    if (!EqualityComparer<TInterface>.Default.Equals(this.collection[i], other.collection[i]))
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
        public override bool Equals(object obj) => obj is OneOrMany<TInterface, TImplementation> ? this.Equals((OneOrMany<TInterface, TImplementation>)obj) : false;

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

        /// <summary>
        /// Checks whether the generic T item is a string that is either null or contains whitespace.
        /// </summary>
        /// <returns>
        /// Returns true if the supplied item is a string that is null or contains whitespace.
        /// </returns>
        private static bool IsStringNullOrWhiteSpace(TInterface item) => item.GetType() == typeof(string) && string.IsNullOrWhiteSpace(item as string);
    }
}
