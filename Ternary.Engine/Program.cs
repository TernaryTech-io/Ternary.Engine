using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ternary.Engine.Core.Logging;



//await TernaryAppBuilder.Create(args)
//        .Build()
//        .RunAsync();

var log = new TernaryLogger();
var type = log.WhatType();
console.WriteLine(type.Name);
