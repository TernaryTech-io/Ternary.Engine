using Microsoft.EntityFrameworkCore;

namespace Ternary.Engine.Example;

public class ExampleService : ServiceBase<WorkDbContext>
{
    public override ExampleDbContext ServiceDbContext => GetDbContext<ExampleDbContext>();
    public ExampleService(IDynamicContextFactory contextFactory,
        ILogger<IServiceBase> logger) : base(contextFactory, logger)
    {

    }

    /*-----------------------------------SERVICE
        Use the service to write common functions for interacting with the database. 
        Many functions for finding, saving, updating, are already inherited.
    */
}

