
namespace Ternary.Engine.Custom;

public class ExtractService : ServiceBase<ExtractDbContext>
{
    public override ExtractDbContext ServiceDbContext => GetDbContext<ExtractDbContext>();
    public ExtractService(DynamicContextFactory contextFactory,
        ILogger<IServiceBase> logger) : base(contextFactory, logger)
    {

    }

    /*-----------------------------------SERVICE
        Use the service to write common functions for interacting with the database. 
        Many functions for finding, saving, updating, are already inherited.
    */
}

