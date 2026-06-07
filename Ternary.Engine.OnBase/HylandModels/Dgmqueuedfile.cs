using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dgmqueuedfile
{
    public long Dgmqueuedfilenum { get; set; }

    public long? Dgmigratorjobnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public string? Filepath { get; set; }

    public long? Failurecount { get; set; }
}
