using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Storageautomationjob
{
    public long Sajobnum { get; set; }

    public long? Sajobtype { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Physicalplatternum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Jobstate { get; set; }

    public long? Queuedstate { get; set; }

    public long? Enabled { get; set; }

    public long? Errortype { get; set; }

    public long? Errorstate { get; set; }

    public long? Runcount { get; set; }

    public long? Errorcount { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Completedate { get; set; }

    public long? Timeelapsed { get; set; }

    public string? Saoldlastuseddrive { get; set; }

    public string? Sanewlastuseddrive { get; set; }

    public long? Flags { get; set; }

    public long? Priority { get; set; }

    public long? Reportoptions { get; set; }
}
