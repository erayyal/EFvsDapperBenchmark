using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Dapper;
using EFvsDapperBenchmark;
using Microsoft.Data.SqlClient;

public class Program
{
    //ENTITY FRAMEWORK BENCHMARK
    [Benchmark]
    public void GetAllWithEntityFramework()
    {
        using (var dbContext = new Context())
        {
            var brands = dbContext.BrandS.ToList();
        }
    }

    //DAPPER BENCHMARK
    private string connectionString = "CONNECTION_STRING";

    [Benchmark]
    public void GetAllWithDapper()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var result = connection.Query<Brand>("SELECT * FROM Brand");
        }
    }

    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<Program>();
    }
}