using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xmldataport
{
    public long Portfmtnum { get; set; }

    public string? Portfmtname { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Uniditemtypenum { get; set; }

    public long? Flags { get; set; }
}
