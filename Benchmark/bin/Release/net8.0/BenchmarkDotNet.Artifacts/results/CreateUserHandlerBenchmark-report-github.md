```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
AMD Ryzen 5 5500U with Radeon Graphics, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-DFPGJJ : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2

IterationCount=10  

```
| Method     | Mean     | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|----------- |---------:|----------:|----------:|-------:|-------:|----------:|
| CreateUser | 2.143 μs | 0.3083 μs | 0.2039 μs | 0.0916 | 0.0229 |     584 B |
