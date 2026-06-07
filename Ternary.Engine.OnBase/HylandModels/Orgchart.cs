using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Orgchart
{
    public long Orgchartnum { get; set; }

    public long? Institution { get; set; }

    public string? Orgchartname { get; set; }

    public long? Flags { get; set; }
}
