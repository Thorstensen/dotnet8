using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;

namespace Frozen.Benchmarks;

public class CreateFrozenSetBenchmark
{
    private const int NumberOfIterations = 2000;
    
    [Benchmark(Baseline = true)]
    public void CreateList()
    {
        _ = Enumerable.Range(0, NumberOfIterations).ToList();
    }

    [Benchmark]
    public void CreateHashSet()
    {
        _ = Enumerable.Range(0, NumberOfIterations).ToHashSet();
    }

    [Benchmark]
    public void CreateFrozenSet()
    {
        _ = Enumerable.Range(0, NumberOfIterations).ToFrozenSet();
    }
}