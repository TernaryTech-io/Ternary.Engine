using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autopubjob
{
    public long Autopubjobnum { get; set; }

    public long? Schedordernum { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public DateTime? Processingdate { get; set; }

    public long? Status { get; set; }

    public long? Envelopenum { get; set; }
}
