namespace Schema.NET
{
    using System;
    using System.Collections.Concurrent;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// A faster version of <see cref="Activator.CreateInstance(Type, object[])"/> by providing constructor delegates.
    /// </summary>
    internal static class FastActivator
    {
        private static readonly ConcurrentDictionary<(Type, Type), Delegate> ConstructorDelegateLookup = new ConcurrentDictionary<(Type, Type), Delegate>();

        /// <summary>
        /// Creates a constructor delegate for the specified type.
        /// </summary>
        /// <typeparam name="T1">Type of first argument for constructor.</typeparam>
        /// <param name="objectType">The object to find the constructor.</param>
        /// <returns>The constructor delegate.</returns>
        public static Func<T1, object> GetDynamicConstructor<T1>(Type objectType)
        {
            var constructorKey = (objectType, typeof(T1));
            if (!ConstructorDelegateLookup.TryGetValue(constructorKey, out var constructorDelegate))
            {
                var constructor = GetConstructorInfo(objectType, typeof(T1));
                constructorDelegate = CreateConstructorDelegate<T1>(constructor);
                ConstructorDelegateLookup.TryAdd(constructorKey, constructorDelegate);
            }

            return constructorDelegate as Func<T1, object>;
        }

        private static Func<T1, object> CreateConstructorDelegate<T1>(ConstructorInfo constructor) => Expression.Lambda<Func<T1, object>>(
                Expression.Convert(
                    Expression.New(constructor, ConstructorParameter<T1>.SingleParameter),
                    typeof(object)),
                ConstructorParameter<T1>.SingleParameter).Compile();

        private static ConstructorInfo GetConstructorInfo(Type objectType, Type parameter1)
        {
            foreach (var constructor in objectType.GetTypeInfo().DeclaredConstructors)
            {
                var parameters = constructor.GetParameters();
                if (constructor.IsPublic && parameters.Length == 1 && parameters[0].ParameterType == parameter1)
                {
                    return constructor;
                }
            }

            return null;
        }

        private static class ConstructorParameter<T1>
        {
            public static readonly ParameterExpression[] SingleParameter = new[] { Expression.Parameter(typeof(T1)) };
        }
    }
}
