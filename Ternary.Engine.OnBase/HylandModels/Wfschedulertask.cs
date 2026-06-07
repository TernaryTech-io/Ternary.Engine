using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfschedulertask
{
    public long Schedtasknum { get; set; }

    public long? Timernum { get; set; }

    public long? Statenum { get; set; }

    public long? Flags { get; set; }
}
