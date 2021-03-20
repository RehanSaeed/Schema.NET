namespace Schema.NET
{
    using System;
    using System.Reflection;

    /// <summary>
    /// <see cref="Type"/> extension methods.
    /// </summary>
    internal static class TypeExtensions
    {
        /// <summary>
        /// Determines whether the type is nullable.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns><c>true</c> if the specified type is nullable; otherwise, <c>false</c>.</returns>
        public static bool IsNullable(this Type type) =>
            type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);

        /// <summary>
        /// Determines whether the type is a primitive type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns><c>true</c> if the type is a primitive type; otherwise, <c>false</c>.</returns>
        public static bool IsPrimitiveType(this Type type) =>
            type.GetTypeInfo().IsPrimitive || type == typeof(string);

        /// <summary>
        /// Gets the underlying type from the potentially nullable type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The underlying type if nullable, otherwise returns the type itself.</returns>
        public static Type GetUnderlyingTypeFromNullable(this Type type) =>
            type.IsNullable() ? Nullable.GetUnderlyingType(type)! : type;
    }
}
