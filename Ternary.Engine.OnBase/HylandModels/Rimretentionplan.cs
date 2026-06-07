using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rimretentionplan
{
    public long Retentionplannum { get; set; }

    public string? Retentionplanname { get; set; }

    public string? Retentionplandesc { get; set; }

    public string? Applicationdesc { get; set; }

    public long? Retentionflags { get; set; }

    public long? Destructionflags { get; set; }

    public long? Retentionperiod { get; set; }

    public long? Retentionunits { get; set; }

    public long? Closeinterval { get; set; }

    public long? Closeunits { get; set; }

    public long? Closesysinterval { get; set; }

    public long? Cutoffinterval { get; set; }

    public long? Cutoffunits { get; set; }

    public long? Cutoffsysinterval { get; set; }

    public DateTime? Creationdate { get; set; }

    public long? Createdby { get; set; }
}
