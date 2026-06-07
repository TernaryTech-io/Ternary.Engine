using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autodeljob
{
    public long Autodeljobnum { get; set; }

    public long? Autodelrulenum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Physicalplatternum { get; set; }

    public DateTime? Timequeued { get; set; }

    public DateTime? Lastattempt { get; set; }

    public long? Lastabortreason { get; set; }

    public long? Disabled { get; set; }

    public long? Jobstate { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Holduntil { get; set; }

    public string? Jobstatereason { get; set; }
}
