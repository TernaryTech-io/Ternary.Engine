
namespace Ternary.Engine.Custom;

/// <summary>
/// Services should be where you build your common functions for interacting with your DbContext. 
/// </summary>
public class MyExampleService : ServiceBase<MyExampleDbContext>
{
    public override MyExampleDbContext ServiceDbContext => GetDbContext<MyExampleDbContext>();
    public MyExampleService(DynamicContextFactory contextFactory,
        ILogger<IServiceBase> logger) : base(contextFactory, logger)
    {

    }

    /*-----------------------------------SERVICE
        Use the service to write common functions for interacting with the database. 
        Many functions for finding, saving, updating, are already inherited.
    */
    public async Task<MyExampleEntity?> GetAsync(string name)
    {
        //DbContexts are scoped and should be created fresh for each operation.
        using var db = GetDbContext<MyExampleDbContext>();
        return db.Examples.AsQueryable()
            .Where(e => e.Name == name)
            .FirstOrDefault();
    }
}

