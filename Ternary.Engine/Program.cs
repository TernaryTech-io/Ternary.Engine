
string[] ctxArgs = ["context", "list"];

await TernaryAppBuilder.Create(ctxArgs)
        .Build()
        .RunAsync();