using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Revnotetable
{
    public long Filetypenum { get; set; }

    public long Docrevnum { get; set; }

    public long Itemnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Docrevdate { get; set; }

    public string? Notetext { get; set; }

    public long? Publishdate { get; set; }

    public string? Releasename { get; set; }

    public DateTime? Releasedate { get; set; }

    public long? Releaseusernum { get; set; }

    public long? Revisionnum { get; set; }

    public DateTime? Effectivedate { get; set; }

    public DateTime? Supercededdate { get; set; }
}
