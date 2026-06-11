
namespace Ternary.Engine.MyExampleWorkerService;

public class MyExampleWorker : WorkerBase<MyExampleService>
{
    public MyExampleWorker(MyExampleService service, ILogger<MyExampleWorker> logger, IGlobalContext context)
        :base( service, logger, context)
    {
       /* Many built in methods are virtual and can be overriden
            - RunAsync: Allows for customizing the logic at the batch level.
            - QueueDelayedJobs: Allows for customizing how delayed jobs are handled.
            - QueueCustomJobs: Allows for logic to queue custom work items.
       */
    }
    /// <summary>
    /// Define the work that is executed before WorkItems begin to process. 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    protected override async Task OnBeforeExecute(IGlobalContext context)
    {
        /*----------------PERFORM WORK TO SEED DATA OR CREATE NEW WORK ITEMS*/
        Logger.LogInformation("Checking for Seed Data...");

        var seedDirectory = context.GlobalProperties.Get<string>("SeedDirectory");
        var sfilter = context.GlobalProperties.Get<string>("SeedFileFilter");
        if (seedDirectory != null)
        {
            //Do Work
        }

        Logger.LogInformation("Checking for Intake Items...");
        var intakeDirectory = context.GlobalProperties.Get<string>("IntakeDirectory");
        var ifilter = context.GlobalProperties.Get<string>("IntakeFileFilter") ?? "*.tsv";
        if (intakeDirectory != null)
        {
            //Create WorkItems from entities
            //await Service.SaveItemsSafeAsync([items]);
        }
    }   
}
