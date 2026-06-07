using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Datacapturestat
{
    public long? Itemnum { get; set; }

    public long? Pagecount { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Captureprocessid { get; set; }

    public string? Captureprocessname { get; set; }

    public long? Captureprocessstatus { get; set; }

    public long? Pagesprocessed { get; set; }

    public long? Batchnum { get; set; }

    public long? Queuenum { get; set; }

    public long? Originalitemnum { get; set; }

    public long? Originalpagecount { get; set; }

    public long? Originalitemtypenum { get; set; }

    public DateTime? Startprocessttime { get; set; }

    public DateTime? Endprocesstime { get; set; }

    public long Datacapstatsnum { get; set; }

    public long? Totalocrchars { get; set; }

    public long? Avgocrcharsperpage { get; set; }

    public string? Capturemachinename { get; set; }

    public long? Terminalsession { get; set; }

    public long? Processid { get; set; }
}
