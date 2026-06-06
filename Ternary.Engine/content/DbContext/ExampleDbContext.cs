namespace Ternary.Engine.Example;

public class ExampleDbContext : BaseDbContext<ExampleDbContext>
{
    public ExampleDbContext(DbContextOptions<ExampleDbContext> options, ILogger<ExampleDbContext> logger) : base(options, logger)
    {
        
    }
    public DbSet<ExampleEntity> Examples { get; init; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<ExampleEntity>(e =>
        {
            e.ToTable("Example", "exp")
            .HasIndex(e => e.Id);
        });
    }
}
