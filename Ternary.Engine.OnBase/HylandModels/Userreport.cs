using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Userreport
{
    public long Reportnum { get; set; }

    public string? Reportname { get; set; }

    public long? Reporttypenum { get; set; }

    public long? Archiveflags { get; set; }

    public string? Tempoutputname { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Vbscriptnum { get; set; }

    public long? Itemnum { get; set; }
}
