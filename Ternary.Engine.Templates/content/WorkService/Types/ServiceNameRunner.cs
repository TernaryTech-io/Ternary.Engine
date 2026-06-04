namespace Ternary.Engine.ServiceName;

public class ServiceNameRunner : WorkRunner
{
    public new ServiceNameService Service { get => (ServiceNameService)base.Service; }

    public ServiceNameRunner(WorkStep step, WorkContext<ServiceNameService> context, ServiceNameService service)
        : base(step, context, service)
    {
    }

    public override async Task<WorkItem> RunItemAsync(WorkItem item, IWorkContext context)
    {
        throw new NotImplementedException();
    }
}
