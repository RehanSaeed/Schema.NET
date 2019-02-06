namespace Schema.NET
{
    using System;

    /// <summary>
    /// An implementation for IValue, containing either type T, or string.
    /// e.g. Brand="Volvo"; is Volvo a brand or an organization, leaving it in the middle
    /// but ExplicitlySet will be set to true.
    /// </summary>
    /// <typeparam name="T1">The first type the values can take.</typeparam>
    /// <typeparam name="T2">The second type the values can take.</typeparam>
    /// <seealso cref="IValue" />
    public struct Values<T1, T2> : IValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1, T2}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
        public Values(T1 value)
        {
            this.Value = value;
            this.ExplicitlySet = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1, T2}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T2"/>.</param>
        public Values(T2 value)
        {
            this.Value = value;
            this.ExplicitlySet = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1, T2}"/> struct
        /// </summary>
        /// <param name="value">The value of type string.</param>
        public Values(string value)
        {
            this.Value = value;
            this.ExplicitlySet = true;
        }

        /// <summary>
        /// Get the value set as constructor
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// True, when the object is explicitly set as a string
        /// </summary>
        public bool ExplicitlySet { get; private set; }

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2>(T1 item) => new Values<T1, T2>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1, T2>(T2 item) => new Values<T1, T2>(item);

        /// <summary>
        /// Performs an explicit conversion from string <see cref="Values{T1, T2}"/>, also sets the <see cref="ExplicitlySet"/> to true.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Values<T1, T2>(string item) => new Values<T1, T2>(item);
    }
}