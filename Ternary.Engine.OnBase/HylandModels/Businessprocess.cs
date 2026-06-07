using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Businessprocess
{
    public long Bpnum { get; set; }

    public string? Bpname { get; set; }

    public string? Bpdescription { get; set; }

    public long? Flags { get; set; }
}
