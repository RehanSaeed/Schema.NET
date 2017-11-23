namespace Schema.NET
{
    using System;
    using System.Reflection;

    internal static class TypeExtensions
    {
        public static bool IsNullable(this Type type) =>
            type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);

        public static bool IsPrimitiveType(this Type type) => type.GetTypeInfo().IsPrimitive || type == typeof(string);

        public static Type GetUnderlyingTypeFromNullable(this Type type) =>
            type.IsNullable() ? Nullable.GetUnderlyingType(type) : type;
    }
}
