using DAL.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DAL.EF;

public class SamplingContext : DbContext
{
    public DbSet<Data> Data { get; set; }
    public DbSet<Operator> Operators { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<SamplingPlan> SamplingPlans { get; set; }
    public DbSet<Sensor> Sensors { get; set; }
    public DbSet<Statistics> Statistics { get; set; }
    public DbSet<UnplannedSampling> UnplannedSamplings { get; set; }
    public DbSet<WaterQualityStandard> WaterQualityStandards { get; set; }
    public DbSet<Waterwell> WaterWells { get; set; }

    public SamplingContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}