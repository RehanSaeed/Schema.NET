namespace Schema.NET.Tool.ViewModels
{
    using System;
    using System.Diagnostics;

    [DebuggerDisplay("{Name}")]
    public class EnumerationValue
    {
        public string Description { get; set; }

        public string Name { get; set; }

        public Uri Uri { get; set; }
    }
}
