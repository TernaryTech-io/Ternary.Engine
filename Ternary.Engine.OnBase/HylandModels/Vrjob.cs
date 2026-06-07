using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vrjob
{
    public long Verrepnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Ctrlflags { get; set; }

    public DateTime? Endtime { get; set; }

    public DateTime? Itemdate { get; set; }

    public long? Jobnum { get; set; }

    public long? Parsefilenum { get; set; }

    public DateTime? Starttime { get; set; }

    public string? Vrfilepath { get; set; }
}
