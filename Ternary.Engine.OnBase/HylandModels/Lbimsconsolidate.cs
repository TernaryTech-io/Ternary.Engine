using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimsconsolidate
{
    public long Consolidationnum { get; set; }

    public long? Lockboxnum { get; set; }

    public long? Consolidationid { get; set; }

    public DateTime? Consolidationdate { get; set; }

    public long? Batchcount { get; set; }

    public long? Checkcount { get; set; }

    public long? Stubcount { get; set; }

    public decimal? Deposittotal { get; set; }
}
