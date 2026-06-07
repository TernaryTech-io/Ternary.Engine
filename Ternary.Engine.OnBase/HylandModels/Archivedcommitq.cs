using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Archivedcommitq
{
    public long Batchnum { get; set; }

    public long? Queuenum { get; set; }

    public string? Queuename { get; set; }

    public string? Batchname { get; set; }

    public long? Tmpdiskgroupnum { get; set; }

    public long? Tmplogicalplttrnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Datestarted { get; set; }

    public DateTime? Dateended { get; set; }

    public long? Numberdocuments { get; set; }

    public long? Archiveflags { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Iconnum { get; set; }

    public long? Lastusedplatter { get; set; }

    public long? Totalpages { get; set; }

    public DateTime? Printeddate { get; set; }

    public long? Totaldocuments { get; set; }

    public DateTime? Commitdate { get; set; }
}
