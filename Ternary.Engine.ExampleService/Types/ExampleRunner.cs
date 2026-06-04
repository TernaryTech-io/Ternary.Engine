namespace Ternary.Engine.Example;
public class ExampleRunner : WorkRunner
{
    public new ExampleService Service { get => (ExampleService)base.Service; }
    public ExampleRunner(WorkStep step, WorkContext<ExampleService> context, ExampleService service) : base(step, context, service)
    {

    }
    public override async Task<WorkItem> RunItemAsync(WorkItem item, IWorkContext context)
    {
        throw new NotImplementedException();        
    }
}
