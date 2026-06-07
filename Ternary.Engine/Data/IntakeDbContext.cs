namespace Ternary.Engine.Custom;

public class IntakeDbContext : BaseDbContext<IntakeDbContext>
{
    public IntakeDbContext(DbContextOptions options, ILogger logger) : base(options, logger)
    {
        
    }
    public DbSet<IntakeEntity> Examples { get; init; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IntakeEntity>(e =>
        {
            e.ToTable("Example", "exp")
            .HasIndex(e => e.Id);
        });
    }
}
