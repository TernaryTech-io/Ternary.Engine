namespace Ternary.Engine.Custom;

public class ExtractDbContext : BaseDbContext<ExtractDbContext>
{
    public ExtractDbContext(DbContextOptions options, ILogger logger) : base(options, logger)
    {
        
    }
    public DbSet<ExtractEntity> Examples { get; init; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<ExtractEntity>(e =>
        {
            e.ToTable("ExtractEntity", "exp")
            .HasIndex(e => e.Id);
        });
    }
}
