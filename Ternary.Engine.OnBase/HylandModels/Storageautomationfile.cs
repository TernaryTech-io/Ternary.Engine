using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Storageautomationfile
{
    public long? Sajobnum { get; set; }

    public string? Filepath { get; set; }

    public long? Jobstate { get; set; }

    public long? Errorstate { get; set; }

    public long? Enabled { get; set; }

    public long? Runcount { get; set; }

    public long? Flags { get; set; }
}
