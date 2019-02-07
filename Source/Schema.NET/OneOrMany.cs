namespace Schema.NET
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class OneOrMany<T> : IEnumerable<T>
    {
        private IList<T> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="item">The single item value.</param>
        public OneOrMany(T item)
        {
            list = new List<T> { item };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneOrMany{T}"/> struct.
        /// </summary>
        /// <param name="list">The list of values.</param>
        public OneOrMany(IEnumerable<T> list)
        {
            this.list = list as IList<T> ?? new List<T>(list);
        }

        /// <summary>
        /// Gets a value indicating whether this instance has a single or list of values.
        /// </summary>
        /// <value><c>true</c> if this instance has at least one value; otherwise, <c>false</c>.</value>
        public bool HasValue => list != null && list.Count > 0;

        /// <summary>
        /// Gets the single item value.
        /// </summary>
        /// <value>The single item value.</value>
        public T Item => list.Single();

        /// <summary>
        /// Gets the list of values.
        /// </summary>
        /// <value>The list of values.</value>
        public IList<T> List => list;

        /// <summary>
        /// Retrieve the first value as T, or the Lst when multiple are found
        /// </summary>
        /// <returns></returns>
        public object Value => list != null && list.Count == 1 ? (object) Item : List;

        public void Add(T item)
        {
            if (list == null) list = new List<T>();
            list.Add(item);
        }

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T[]"/> to <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <param name="array">The array of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator OneOrMany<T>(T[] array) => new OneOrMany<T>(array);


        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T"/> to <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator OneOrMany<T>(T item) => new OneOrMany<T>(item);

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
        public IEnumerator<T> GetEnumerator() => (this.list ?? new List<T>()).GetEnumerator();

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="OneOrMany{T}"/>.
        /// </summary>
        /// <returns>An enumerator for the <see cref="OneOrMany{T}"/>.</returns>
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();              
    }
}
