using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemdatarelease
{
    public long Releasenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public DateTime? Releasedate { get; set; }

    public string? Notetext { get; set; }

    public long? Usernum { get; set; }

    public string? Nomenclature { get; set; }

    public long? Revision { get; set; }

    public DateTime? Effectivedate { get; set; }

    public DateTime? Supercededdate { get; set; }

    public long? Status { get; set; }
}
