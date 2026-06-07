using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Classifyreport
{
    public long Classifyreportnum { get; set; }

    public long? Clsystemnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Haserror { get; set; }

    public long? Isread { get; set; }

    public DateTime? Dateread { get; set; }
}
