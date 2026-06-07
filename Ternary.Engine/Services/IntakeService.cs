
namespace Ternary.Engine.Custom;

public class IntakeService : ServiceBase<IntakeDbContext>
{
    public override IntakeDbContext ServiceDbContext => GetDbContext<IntakeDbContext>();
    public IntakeService(IDynamicContextFactory contextFactory,
        ILogger<IServiceBase> logger) : base(contextFactory, logger)
    {

    }

    /*-----------------------------------SERVICE
        Use the service to write common functions for interacting with the database. 
        Many functions for finding, saving, updating, are already inherited.
    */
}

