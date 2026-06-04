namespace Ternary.Engine.ServiceName;

public class ServiceNameWorker : WorkerBase<ServiceNameWorker, ServiceNameService>
{
    public ServiceNameWorker(ServiceNameService service, ILogger<ServiceNameWorker> logger, IRunContext context)
        : base(service, logger, context)
    {
    }

    public override WorkerType WorkerType => WorkerType.Extract;

    public override async Task OnBeforeExecute(IRunContext context)
    {
        throw new NotImplementedException();
    }
}
