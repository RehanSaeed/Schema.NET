namespace Schema.NET
{
    using System.Collections.Generic;

    /// <summary>
    /// A single or list of values which can be any of the specified types.
    /// </summary>
    /// <typeparam name="T1">The first type the values can take.</typeparam>
    /// <typeparam name="T2">The second type the values can take.</typeparam>
    /// <seealso cref="IValue" />
    public class Values<T1, T2> : IValue
    {
        private readonly OneOrMany<T1> value1;
        private readonly OneOrMany<T2> value2;

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2}"/> class.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
        public Values(OneOrMany<T1> value)
        {
            this.value1 = value;
            this.value2 = default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2}"/> class.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T2"/>.</param>
        public Values(OneOrMany<T2> value)
        {
            this.value1 = default;
            this.value2 = value;
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T1" />.
        /// </summary>
        public OneOrMany<T1> Value1 => this.value1;

        /// <summary>
        /// Gets the value of type <typeparamref name="T2" />.
        /// </summary>
        public OneOrMany<T2> Value2 => this.value2;

        /// <summary>
        /// Gets the non-null object representing the instance.
        /// </summary>
        object IValue.Value
        {
            get
            {
                if (this.value1?.Count > 0)
                {
                    return ((IValue)this.value1).Value;
                }
                else if (this.value2?.Count > 0)
                {
                    return ((IValue)this.value2).Value;
                }

                return null;
            }
        }

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2>(T1 item) => item == null || (item.GetType() == typeof(string) && string.IsNullOrWhiteSpace(item as string)) ? null : new Values<T1, T2>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T2"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2>(T2 item) => item == null || (item.GetType() == typeof(string) && string.IsNullOrWhiteSpace(item as string)) ? null : new Values<T1, T2>(item);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T1}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2>(List<T1> list) => list == null || list.Count == 0 ? null : new Values<T1, T2>(list);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T2}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2>(List<T2> list) => list == null || list.Count == 0 ? null : new Values<T1, T2>(list);
    }
}
