using Microsoft.EntityFrameworkCore;

namespace Ternary.Engine.ServiceName;

public class ServiceNameDbContext : BaseDbContext<ServiceNameDbContext>
{
    public ServiceNameDbContext(DbContextOptions<ServiceNameDbContext> options, ILogger<ServiceNameDbContext> logger)
        : base(options, logger)
    {
    }

    public DbSet<ServiceNameEntity> ServiceNames { get; init; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<ServiceNameEntity>(e =>
        {
            e.ToTable("ServiceName", "mig")
             .HasIndex(e => e.Id);
        });
    }
}
