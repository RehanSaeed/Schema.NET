using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// TODO, might not work with the changes made
/// </summary>


namespace Schema.NET
{
    [JsonConverter(typeof(WrapperConverter))]
    public interface IWrapper { object Data { get; set; } } 
    public interface IValue { object Value { get; } }
    public interface IValue<T> : IValue { void Add(T item); }

    public struct Values<T> : IValue<T>
    {
        private List<T> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T}"/> struct.
        /// </summary>
        /// <param name="item">The single item value.</param>
        public Values(T item)
        {
            list = new List<T> { item };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T}"/> struct.
        /// </summary>
        /// <param name="list">The list of values.</param>
        public Values(List<T> list)
        {
            this.list = list;
        }

        /// <summary>
        /// Gets a value indicating whether this instance has a single or list of values.
        /// </summary>
        /// <value><c>true</c> if this instance has at least one value; otherwise, <c>false</c>.</value>
        public bool HasValue => list != null && list.Any();

        /// <summary>
        /// Gets the single item value.
        /// </summary>
        /// <value>The single item value.</value>
        public T Item => list.First();

        /// <summary>
        /// Gets the list of values.
        /// </summary>
        /// <value>The list of values.</value>
        public List<T> List => list;

        public object Value => list != null && list.Count == 1 ? (object) Item : List;

        public void Add(T item)
        {
            if (list == null) list = new List<T>();
            list.Add(item);
        }

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T"/> to <see cref="Values{T}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T>(T item) => new Values<T>(item);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T}"/> to <see cref="Values{T}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T>(List<T> list) => new Values<T>(list);
    }
}
