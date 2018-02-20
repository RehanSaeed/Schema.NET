namespace Schema.NET
{
    using System.Collections.Generic;

    /// <summary>
    /// A single or list of values which can be any of the specified types.
    /// </summary>
    /// <typeparam name="T1">The first type the values can take.</typeparam>
    /// <typeparam name="T2">The second type the values can take.</typeparam>
    /// <typeparam name="T3">The third type the values can take.</typeparam>
    /// <seealso cref="IValue" />
    public struct Values<T1, T2, T3> : IValue
    {
        private readonly OneOrMany<T1> value1;
        private readonly OneOrMany<T2> value2;
        private readonly OneOrMany<T3> value3;

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
        public Values(OneOrMany<T1> value)
        {
            this.value1 = value;
            this.value2 = default;
            this.value3 = default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T2"/>.</param>
        public Values(OneOrMany<T2> value)
        {
            this.value1 = default;
            this.value2 = value;
            this.value3 = default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T3"/>.</param>
        public Values(OneOrMany<T3> value)
        {
            this.value1 = default;
            this.value2 = default;
            this.value3 = value;
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
        /// Gets the value of type <typeparamref name="T3" />.
        /// </summary>
        public OneOrMany<T3> Value3 => this.value3;

        /// <summary>
        /// Gets the non-null object representing the instance.
        /// </summary>
        object IValue.Value
        {
            get
            {
                if (this.value1.Count > 0)
                {
                    return ((IValue)this.value1).Value;
                }
                else if (this.value2.Count > 0)
                {
                    return ((IValue)this.value2).Value;
                }
                else if (this.value3.Count > 0)
                {
                    return ((IValue)this.value3).Value;
                }

                return null;
            }
        }

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3>(T1 item) => new Values<T1, T2, T3>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T2"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3>(T2 item) => new Values<T1, T2, T3>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T3"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3>(T3 item) => new Values<T1, T2, T3>(item);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T1}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3>(List<T1> list) => new Values<T1, T2, T3>(list);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T2}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3>(List<T2> list) => new Values<T1, T2, T3>(list);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T3}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3>(List<T3> list) => new Values<T1, T2, T3>(list);
    }
}
