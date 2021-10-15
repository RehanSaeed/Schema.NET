namespace Schema.NET.Benchmarks
{
    using BenchmarkDotNet.Running;

    public class Program
    {
        private static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
