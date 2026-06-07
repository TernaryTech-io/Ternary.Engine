namespace Ternary.Engine.Custom;

public class MyExampleDbContext : BaseDbContext<MyExampleDbContext>
{
    public MyExampleDbContext(DbContextOptions options, ILogger logger) : base(options, logger)
    {
        
    }
    public DbSet<MyExampleEntity> Examples { get; init; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<MyExampleEntity>(e =>
        {
            e.ToTable("MyExampleEntity", "exp")
            .HasIndex(e => e.Id);
        });
    }
}
