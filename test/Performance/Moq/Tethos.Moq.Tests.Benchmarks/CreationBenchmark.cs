namespace Tethos.Moq.Tests.Benchmarks
{
    using System.Diagnostics.CodeAnalysis;
    using BenchmarkDotNet.Attributes;

    [ShortRunJob]
    public class CreationBenchmark
    {
        [Benchmark(Description = "Moq.MakeFactory")]
        [SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Framework requirement")]
        public void MakeFactory() => AutoMocking.Create();
    }
}