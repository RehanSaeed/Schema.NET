namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using Schema.NET.Tool.ViewModels;

    public class WarnEmptyEnumerations : IEnumerationOverride
    {
        public bool CanOverride(Enumeration enumeration)
        {
            if (enumeration is null)
            {
                throw new ArgumentNullException(nameof(enumeration));
            }

            return enumeration.Values.Count == 0;
        }

        public void Override(Enumeration enumeration)
        {
            if (enumeration is null)
            {
                throw new ArgumentNullException(nameof(enumeration));
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Enumeration {enumeration.Layer}.{enumeration.Name} has no values");
            Console.ResetColor();
        }
    }
}
