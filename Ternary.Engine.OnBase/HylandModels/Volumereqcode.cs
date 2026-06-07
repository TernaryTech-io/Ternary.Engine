using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Volumereqcode
{
    public long Volumereqcodenum { get; set; }

    public long? Facilitynum { get; set; }

    public string? Reasontext { get; set; }

    public long? Numberofdays { get; set; }

    public long? Flags { get; set; }
}
