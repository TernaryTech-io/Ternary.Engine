using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Atprogram
{
    public long Atprogramnum { get; set; }

    public string? Atprogramname { get; set; }

    public string? Atjobgroupname { get; set; }

    public long? Flags { get; set; }

    public long? Status { get; set; }
}
