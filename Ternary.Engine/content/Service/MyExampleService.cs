
namespace Ternary.Engine.Custom;

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
}

