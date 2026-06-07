using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimsnotifysched
{
    public long Imsschednum { get; set; }

    public long? Imsnotifynum { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public DateTime? Processingdate { get; set; }

    public long? Status { get; set; }
}
