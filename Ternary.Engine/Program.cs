
string[] ctxArgs = ["context", "list"];

await TernaryAppBuilder.Create(args)
        .Build()
        .RunAsync();