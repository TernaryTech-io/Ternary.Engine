using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecgroup
{
    public long Ecgroupnum { get; set; }

    public string? Ecgroupname { get; set; }

    public long? Ecownernum { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Flags { get; set; }
}
