namespace Schema.NET
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// A single or list of values.
    /// </summary>
    /// <typeparam name="T">The type of the values.</typeparam>
    /// <seealso cref="ICollection{T}" />
    public struct OneOrMany<T> : IEnumerable<T>, IValue
    {
        private readonly List<T> collection;
        private readonly T item;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="item">The single item value.</param>
        public OneOrMany(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            this.collection = null;
            this.item = item;
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
        /// Gets the non-null object representing the instance.
        /// </summary>
        public object Value
        {
            get
            {
                if (this.HasOne)
                {
                    return this.item;
                }

                return this.collection;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has a single item value.
        /// </summary>
        /// <value><c>true</c> if this instance has a single item value; otherwise, <c>false</c>.</value>
        public bool HasOne => this.item != null;

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
        public static implicit operator OneOrMany<T>(T item) => new OneOrMany<T>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T[]"/> to <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <param name="array">The array of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator OneOrMany<T>(T[] array) => new OneOrMany<T>(array);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T}"/> to <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator OneOrMany<T>(List<T> list) => new OneOrMany<T>(list);

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <returns>An enumerator for the <see cref="OneOrMany{T}"/>.</returns>
        public IEnumerator<T> GetEnumerator() => (this.collection ?? new List<T>() { this.item }).GetEnumerator();

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <returns>An enumerator for the <see cref="OneOrMany{T}"/>.</returns>
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
