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
    /// <typeparam name="T4">The fourth type the values can take.</typeparam>
    /// <seealso cref="IValue" />
    public struct Values<T1, T2, T3, T4> : IValue
    {
        private readonly Values<T1> values1;
        private readonly Values<T2> values2;
        private readonly Values<T3> values3;
        private readonly Values<T4> values4;

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4}"/> struct.
        /// </summary>
        /// <param name="values">The value of type <typeparamref name="T1"/>.</param>
        public Values(Values<T1> values)
        {
            this.values1 = values;
            this.values2 = default(Values<T2>);
            this.values3 = default(Values<T3>);
            this.values4 = default(Values<T4>);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4}"/> struct.
        /// </summary>
        /// <param name="values">The value of type <typeparamref name="T2"/>.</param>
        public Values(Values<T2> values)
        {
            this.values1 = default(Values<T1>);
            this.values2 = values;
            this.values3 = default(Values<T3>);
            this.values4 = default(Values<T4>);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4}"/> struct.
        /// </summary>
        /// <param name="values">The value of type <typeparamref name="T3"/>.</param>
        public Values(Values<T3> values)
        {
            this.values1 = default(Values<T1>);
            this.values2 = default(Values<T2>);
            this.values3 = values;
            this.values4 = default(Values<T4>);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2,T3,T4}"/> struct.
        /// </summary>
        /// <param name="values">The value of type <typeparamref name="T4"/>.</param>
        public Values(Values<T4> values)
        {
            this.values1 = default(Values<T1>);
            this.values2 = default(Values<T2>);
            this.values3 = default(Values<T3>);
            this.values4 = values;
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
        /// Gets the value of type <typeparamref name="T4" />.
        /// </summary>
        public Values<T4> Values4 => this.values4;

        /// <summary>
        /// Gets the non-null object representing the instance.
        /// </summary>
        public object Value
        {
            get
            {
                if (this.values1.HasValue)
                {
                    return this.values1.Value;
                }
                else if (this.values2.HasValue)
                {
                    return this.values2.Value;
                }
                else if (this.values3.HasValue)
                {
                    return this.values3.Value;
                }
                else if (this.values4.HasValue)
                {
                    return this.values4.Value;
                }

                return null;
            }
        }

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3, T4>(T1 item) => new Values<T1, T2, T3, T4>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T2"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3, T4>(T2 item) => new Values<T1, T2, T3, T4>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T3"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3, T4>(T3 item) => new Values<T1, T2, T3, T4>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T4"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3, T4>(T4 item) => new Values<T1, T2, T3, T4>(item);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T1}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3, T4>(List<T1> list) => new Values<T1, T2, T3, T4>(list);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T2}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3, T4>(List<T2> list) => new Values<T1, T2, T3, T4>(list);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T3}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3, T4>(List<T3> list) => new Values<T1, T2, T3, T4>(list);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T4}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2, T3, T4>(List<T4> list) => new Values<T1, T2, T3, T4>(list);
    }
}
