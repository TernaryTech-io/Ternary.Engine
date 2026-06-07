using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedulerjob
{
    public long Schedjobnum { get; set; }

    public long? Schedtasknum { get; set; }

    public long? Schedulenum { get; set; }

    public long? Workerpoolnum { get; set; }

    public long? Execservicenum { get; set; }

    public long? Jobstatus { get; set; }

    public long? Jobpriority { get; set; }

    public DateTime? Latestexecutionstart { get; set; }

    public DateTime? Latestexecutionend { get; set; }

    public DateTime? Nextexecutionstart { get; set; }

    public DateTime? Lastheartbeat { get; set; }

    public long? Pulseservicenum { get; set; }

    public long? Flags { get; set; }

    public long? Deferjobstatus { get; set; }
}
