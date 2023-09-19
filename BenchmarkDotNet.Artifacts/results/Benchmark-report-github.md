```

BenchmarkDotNet v0.13.7, macOS Ventura 13.4.1 (c) (22F770820d) [Darwin 22.5.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 6.0.404
  [Host]     : .NET 6.0.12 (6.0.1222.56807), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 6.0.12 (6.0.1222.56807), Arm64 RyuJIT AdvSIMD


```
|                    Method |     Mean |    Error |   StdDev |
|-------------------------- |---------:|---------:|---------:|
| GetAllWithEntityFramework | 26.26 ms | 0.379 ms | 0.316 ms |
|          GetAllWithDapper | 25.70 ms | 0.428 ms | 0.379 ms |
