using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Filedownloadrequest
{
    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public string? Filepath { get; set; }

    public long? Priority { get; set; }

    public DateTime? Timequeued { get; set; }

    public long? Downloadjobid { get; set; }

    public long? Downloadjobtype { get; set; }
}
