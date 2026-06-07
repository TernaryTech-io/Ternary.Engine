using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lcstatextasklist
{
    public long Statenum { get; set; }

    public long Tasklistnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
