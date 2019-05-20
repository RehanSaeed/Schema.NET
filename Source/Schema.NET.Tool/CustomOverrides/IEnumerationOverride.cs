namespace Schema.NET.Tool.CustomOverrides
{
    using Schema.NET.Tool.ViewModels;

    public interface IEnumerationOverride
    {
        bool CanOverride(Enumeration enumeration);

        void Override(Enumeration enumeration);
    }
}
