using Microsoft.EntityFrameworkCore;

namespace EFvsDapperBenchmark;

public class Context:DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("CONNECTION_STRING");
    }
    public DbSet<Brand> BrandS { get; set; }
}