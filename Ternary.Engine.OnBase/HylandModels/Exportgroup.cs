using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Exportgroup
{
    public long Exportgroupnum { get; set; }

    public string? Exportgroupname { get; set; }

    public long? Defaultdate { get; set; }

    public long? Exportgroupflags { get; set; }
}
