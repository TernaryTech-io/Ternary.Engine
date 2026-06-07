using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tasklistxtask
{
    public long Tasklistnum { get; set; }

    public long Tasknum { get; set; }

    public long Flags { get; set; }

    public long? Seqnum { get; set; }
}
