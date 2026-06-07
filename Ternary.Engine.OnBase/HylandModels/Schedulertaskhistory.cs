using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedulertaskhistory
{
    public long Sthistentrynum { get; set; }

    public long? Schedjobnum { get; set; }

    public long? Schedtasknum { get; set; }

    public long? Schedulenum { get; set; }

    public long? Workerpoolnum { get; set; }

    public long? Schedservicenum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Schedexecutionstart { get; set; }

    public DateTime? Schedexecutionend { get; set; }

    public long? Jobstatus { get; set; }

    public long? Flags { get; set; }

    public long? Processedcount { get; set; }
}
