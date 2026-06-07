using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Volumequery
{
    public long Volumequerynum { get; set; }

    public string? Volumequeryname { get; set; }

    public long? Volumereqcodenum { get; set; }

    public long? Hours { get; set; }

    public long? Hoursoptions { get; set; }

    public long? Flags { get; set; }
}
