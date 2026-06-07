using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cloudfileactionqueue
{
    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public string? Filepath { get; set; }

    public long? Physicalplatternum { get; set; }

    public long? Action { get; set; }

    public long? Offset { get; set; }

    public long? Filesize { get; set; }

    public long? Priority { get; set; }

    public DateTime? Timequeued { get; set; }

    public string? Filechecksum { get; set; }

    public DateTime? Lastmodified { get; set; }

    public DateTime? Lastfailedattempt { get; set; }
}
