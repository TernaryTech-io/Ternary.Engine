namespace Ternary.Engine.ServiceName;

public class ServiceNameWorkItem : WorkEntity
{
    public ServiceNameWorkItem(DirectoryInfo serviceNameFolder)
    {
        ServiceNameFolder = serviceNameFolder;
    }

    public DirectoryInfo ServiceNameFolder { get; set; }
}
