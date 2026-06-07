using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lockboxgroup
{
    public long Lockboxgroupnum { get; set; }

    public string? Lockboxgroupname { get; set; }

    public long? Customernum { get; set; }

    public long? Flags { get; set; }
}
