using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpschedule
{
    public long Mpschedulenum { get; set; }

    public string? Mpschedulename { get; set; }

    public string? Mpscheduledescription { get; set; }

    public long? Isenabled { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public long? Status { get; set; }
}
