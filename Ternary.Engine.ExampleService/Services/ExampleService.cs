using Microsoft.EntityFrameworkCore;

namespace Ternary.Engine.Example;

public class ExampleService : ServiceBase<WorkDbContext>
{
    public ExampleService(IDynamicContextFactory contextFactory,
        ILogger<IServiceBase> logger) : base(contextFactory, logger)
    {

    }
}

