using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfschedulertimer
{
    public long Wfschedtimernum { get; set; }

    public string? Wfschedtimername { get; set; }

    public long? Tasklistnum { get; set; }

    public long? Scope { get; set; }

    public long? Flags { get; set; }
}
