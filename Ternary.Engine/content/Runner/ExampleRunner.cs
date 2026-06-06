namespace Ternary.Engine.Example;
public class ExampleRunner : WorkRunner<ExampleService>
{
    public override async Task<WorkItem> RunItemAsync(WorkItem item, IWorkContext context)
    {
        //Wrap in a try-catch for error handling. 
        try
        {
            /*----------------RUNNER METHODS */
            //Retrieve the Entity that the WorkItem references
            var entity = await GetEntity<ExampleEntity>(item);

            //Fall back method if the type isn't known. Returns an IBaseEntity object with limited fields
            //var entity = await GetEntity(item);

            /*----------------ACCESSING THE SERVICE */
            //You service should contain your database operations, many are already inherited
            var refItem = await Service.FindAsync<ExampleEntity>(12345);

            /*----------------ACCESS YOUR DBContext Directly */
            //You can interact with your dbcontext directly as well
            using var db = Service.ServiceDbContext;
            var allEntities = db.Examples.AsQueryable();

            /*----------------ACCESS THE LOGGER */
            //You can access the logger:
            Logger.LogTrace("Trace Level Message");
            Logger.LogDebug("Debug Level Message");
            Logger.LogInformation("Some Information to share");
            Logger.LogWarning("A Warning");
            Logger.LogError("and Error");

            /*----------------ACCESS GLOBAL PROPERTIES */
            //You have access to the GlobalProperties through the context that will persist until the service shuts down.
            var count = context.Properties.Get<int>("count");
            context.Properties.Set("count", count++, true);

            /*----------------ACCESS SCOPED SERVICES */
            //You can create a scope and call scoped services
            using var scope = context.CreateScope();
            var service = scope.ServiceProvider.GetService<ExampleDbContext>();

            /*--------------------------------
             * Perform the work needed here.
             --------------------------------*/

            //Save changes back to the database
            entity = await Service.UpdateAsync(entity);
            
            //Return the item with am updated status. 
            return item.Success();
            //You can also pass a newly created entity to to be queued for the next steps in the place of this entity
            //return item.Success(newEntity);
        }
        catch(Exception ex)
        {
            //Pass the execption to automatically log it.
            return item.Fail(ex);
        }            
    }
}
