namespace Schema.NET.Tool.GeneratorModels
{
    public interface ICloneable<T>
    {
        T Clone();
    }

    public interface ICloneable<TOut, TIn>
    {
        TOut Clone(TIn context);
    }
}
