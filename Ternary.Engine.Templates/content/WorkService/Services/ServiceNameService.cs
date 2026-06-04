namespace Ternary.Engine.ServiceName;

public class ServiceNameService : ServiceBase<WorkDbContext>
{
    public ServiceNameService(IDynamicContextFactory contextFactory,
        ILogger<IServiceBase> logger) : base(contextFactory, logger)
    {
    }
}
