
namespace Ternary.Engine.Example;

public class ExampleWorker : WorkerBase<ExampleWorker, ExampleService>
{
    public ExampleWorker(ExampleService service, ILogger<ExampleWorker> logger, IRunContext context)
        :base( service, logger, context)
    {
       
    }
    public override WorkerType WorkerType => WorkerType.Extract;
    /// <summary>
    /// Perform staging work, like intake or database seeding, create new work batches, etc.
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override async Task OnBeforeExecute(IRunContext context)
    {
        throw new NotImplementedException();
    }   
}
