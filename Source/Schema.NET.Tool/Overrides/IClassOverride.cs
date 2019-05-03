namespace Schema.NET.Tool.Overrides
{
    using Schema.NET.Tool.ViewModels;

    public interface IClassOverride
    {
        bool CanOverride(Class c);

        void Override(Class c);
    }
}
