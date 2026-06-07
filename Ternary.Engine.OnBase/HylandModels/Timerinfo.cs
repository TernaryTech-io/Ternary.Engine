using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Timerinfo
{
    public long Timerinfonum { get; set; }

    public string? Timerinfoname { get; set; }

    public long? Assignedwks { get; set; }

    public long? Timertype { get; set; }

    public long? Intervalcount { get; set; }

    public long? Intervalunit { get; set; }

    public long? Dayofweek { get; set; }

    public DateTime? Timeofday { get; set; }

    public string? Processorname { get; set; }

    public DateTime? Lastrun { get; set; }

    public DateTime? Expiredate { get; set; }

    public long? Timerflags { get; set; }

    public long? Timertime { get; set; }

    public long? Timerday { get; set; }

    public long? Timermonth { get; set; }

    public long? Timeryear { get; set; }

    public long? Timeradjustment { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Lastreset { get; set; }

    public long? Executioncount { get; set; }

    public long? Totalruntime { get; set; }

    public long? Lastruntime { get; set; }

    public long? Maxruntime { get; set; }
}
