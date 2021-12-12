namespace Tethos.FakeItEasy.Tests.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    [ShortRunJob]
    public class FactoryBenchmark
    {
        [Benchmark]
        public void MakeFactory() => AutoMockingContainerFactory.Create();
    }
}