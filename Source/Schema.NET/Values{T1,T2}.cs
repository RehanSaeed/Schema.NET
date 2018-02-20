namespace Schema.NET
{
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// A single or list of values which can be any of the specified types.
    /// </summary>
    /// <typeparam name="T1">The first type the values can take.</typeparam>
    /// <typeparam name="T2">The second type the values can take.</typeparam>
    /// <seealso cref="IValue" />
    public struct Values<T1, T2> : IValue
    {
        private readonly OneOrMany<T1> values1;
        private readonly OneOrMany<T2> values2;

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2}"/> struct.
        /// </summary>
        /// <param name="values">The value of type <typeparamref name="T1"/>.</param>
        public Values(OneOrMany<T1> values)
        {
            this.values1 = values;
            this.values2 = default(OneOrMany<T2>);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2}"/> struct.
        /// </summary>
        /// <param name="values">The value of type <typeparamref name="T2"/>.</param>
        public Values(OneOrMany<T2> values)
        {
            this.values1 = default(OneOrMany<T1>);
            this.values2 = values;
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T1" />.
        /// </summary>
        public OneOrMany<T1> Values1 => this.values1;

        /// <summary>
        /// Gets the value of type <typeparamref name="T2" />.
        /// </summary>
        public OneOrMany<T2> Values2 => this.values2;

        /// <summary>
        /// Gets the non-null object representing the instance.
        /// </summary>
        public object Value
        {
            get
            {
                if (this.values1.Count > 0)
                {
                    return this.values1.Value;
                }
                else if (this.values2.Count > 0)
                {
                    return this.values2.Value;
                }

                return null;
            }
        }

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2>(T1 item) => new Values<T1, T2>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T2"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2>(T2 item) => new Values<T1, T2>(item);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T1}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2>(List<T1> list) => new Values<T1, T2>(list);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T2}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2>(List<T2> list) => new Values<T1, T2>(list);
    }
}
