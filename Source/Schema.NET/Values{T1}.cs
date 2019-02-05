namespace Schema.NET
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An implementation for IValue, containing either type T, or string.
    /// e.g. Brand="Volvo"; is Volvo a brand or an organization, leaving it in the middle
    /// but warning will be set to true, unless T is string.
    /// </summary>
    /// <typeparam name="T1">The first type the values can take.</typeparam>
    /// <seealso cref="IValue" />
    public struct Values<T1> : IValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
        public Values(T1 value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1}"/> struct, using a string
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
        public Values(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Get the value set as constructor
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1>(T1 item) => new Values<T1>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T1>(string item) => new Values<T1>(item);
    }
}
