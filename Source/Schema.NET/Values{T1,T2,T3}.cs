namespace Schema.NET
{
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// A single or list of values which can be any of the specified types.
    /// </summary>
    /// <typeparam name="T1">The first type the values can take.</typeparam>
    /// <typeparam name="T2">The second type the values can take.</typeparam>
    /// <typeparam name="T3">The third type the values can take.</typeparam>
    /// <seealso cref="IValue" />
    public struct Values<T1, T2, T3> : IValue
    {
        private readonly Values<T1> values1;
        private readonly Values<T2> values2;
        private readonly Values<T3> values3;

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="values">The value of type <typeparamref name="T1"/>.</param>
        public Values(Values<T1> values)
        {
            this.values1 = values;
            this.values2 = default(Values<T2>);
            this.values3 = default(Values<T3>);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="values">The value of type <typeparamref name="T2"/>.</param>
        public Values(Values<T2> values)
        {
            this.values1 = default(Values<T1>);
            this.values2 = values;
            this.values3 = default(Values<T3>);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3}"/> struct.
        /// </summary>
        /// <param name="values">The value of type <typeparamref name="T3"/>.</param>
        public Values(Values<T3> values)
        {
            this.values1 = default(Values<T1>);
            this.values2 = default(Values<T2>);
            this.values3 = values;
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T1" />.
        /// </summary>
        public Values<T1> Values1 => this.values1;

        /// <summary>
        /// Gets the value of type <typeparamref name="T2" />.
        /// </summary>
        public Values<T2> Values2 => this.values2;

        /// <summary>
        /// Gets the value of type <typeparamref name="T3" />.
        /// </summary>
        public Values<T3> Values3 => this.values3;

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

        /// <summary>
        /// Gets the non-null object representing the instance.
        /// </summary>
        /// <returns>
        /// The non-null object representing the instance.
        /// </returns>
        public object GetObject()
        {
            if (this.values1.HasValue)
            {
                return this.values1.GetObject();
            }
            else if (this.values2.HasValue)
            {
                return this.values2.GetObject();
            }
            else if (this.values3.HasValue)
            {
                return this.values3.GetObject();
            }

            return null;
        }
    }
}
