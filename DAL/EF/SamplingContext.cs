using lr4;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF;

public class SamplingContext : DbContext
{
    public DbSet<Data> Data { get; set; }
    public DbSet<Operator> Operator { get; set; }
    public DbSet<Report> Report { get; set; }
    public DbSet<SamplingPlan> SamplingPlan { get; set; }
    public DbSet<Sensor> Sensor { get; set; }
    public DbSet<Statistics> Statistics { get; set; }
    public DbSet<UnplannedSampling> UnplannedSampling { get; set; }
    public DbSet<WaterQualityStandard> WaterQualityStandard { get; set; }
    public DbSet<Waterwell> WaterWell { get; set; }

    public SamplingContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}