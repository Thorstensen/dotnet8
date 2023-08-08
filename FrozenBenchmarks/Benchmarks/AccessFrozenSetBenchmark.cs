using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;

namespace Frozen.Benchmarks;

public class AccessFrozenSetBenchmark
{
    private const int NumberOfIterations = 2000;

    private readonly IList<int> _list = Enumerable.Range(0, NumberOfIterations).ToList();
    private readonly HashSet<int> _hashSet = Enumerable.Range(0, NumberOfIterations).ToHashSet();
    private readonly FrozenSet<int> _frozenSet = Enumerable.Range(0, NumberOfIterations).ToFrozenSet();

    [Benchmark(Baseline = true)]
    public void ContainsInList()
    {
        for (var index = 0; index < NumberOfIterations; index++)
            _ = _list.Contains(index);
    }

    [Benchmark]
    public void ContainsHashSet()
    {
        for (var index = 0; index < NumberOfIterations; index++)
            _ = _hashSet.Contains(index);
    }
    
    [Benchmark]
    public void ContainsFrozen()
    {
        for (var index = 0; index < NumberOfIterations; index++)
            _ = _frozenSet.Contains(index);
    }
}