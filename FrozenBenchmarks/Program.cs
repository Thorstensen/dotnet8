using BenchmarkDotNet.Running;
using Frozen.Benchmarks;

var summary = BenchmarkRunner.Run<CreateFrozenSetBenchmark>();