using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Insightschedulertask
{
    public long Schedtasknum { get; set; }

    public long Insightcollectionnum { get; set; }

    public long? Flags { get; set; }
}
