using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Labelentry
{
    public long Jobnum { get; set; }

    public long Seqnum { get; set; }

    public string? Labeltext { get; set; }
}
