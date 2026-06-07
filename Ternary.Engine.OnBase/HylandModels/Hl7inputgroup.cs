using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7inputgroup
{
    public long Hl7inputgroupnum { get; set; }

    public string? Hl7inputgroupname { get; set; }

    public string? Hl7inputgroupswitch { get; set; }

    public long? Flags { get; set; }
}
