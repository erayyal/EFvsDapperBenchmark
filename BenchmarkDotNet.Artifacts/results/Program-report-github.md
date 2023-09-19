```

BenchmarkDotNet v0.13.7, macOS Ventura 13.4.1 (c) (22F770820d) [Darwin 22.5.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 6.0.404
  [Host]     : .NET 6.0.12 (6.0.1222.56807), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 6.0.12 (6.0.1222.56807), Arm64 RyuJIT AdvSIMD


```
|                    Method |     Mean |    Error |    StdDev |   Median |
|-------------------------- |---------:|---------:|----------:|---------:|
| GetAllWithEntityFramework | 60.70 ms | 4.747 ms | 13.771 ms | 52.39 ms |
|          GetAllWithDapper | 49.14 ms | 0.921 ms |  1.261 ms | 48.86 ms |
