using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Labelfield
{
    public long Labelnum { get; set; }

    public long Seqnum { get; set; }

    public long? Labelfieldflags { get; set; }

    public string? Labeltext { get; set; }
}
