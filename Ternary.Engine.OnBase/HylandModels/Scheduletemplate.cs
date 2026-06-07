using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scheduletemplate
{
    public long Schedtemplatenum { get; set; }

    public string? Schedtemplatename { get; set; }

    public long? Calendarmode { get; set; }

    public long? Schedprocnum { get; set; }

    public long? Timemode { get; set; }

    public long? Schedstarttime { get; set; }

    public long? Schedendtime { get; set; }
}
