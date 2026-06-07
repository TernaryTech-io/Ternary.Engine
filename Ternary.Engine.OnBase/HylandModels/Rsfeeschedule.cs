using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rsfeeschedule
{
    public long Feetypenum { get; set; }

    public long? Feetyperevnum { get; set; }

    public string? Feename { get; set; }

    public decimal? Feeamount { get; set; }

    public decimal? Maxfeeamount { get; set; }

    public long? Unitofmeasure { get; set; }

    public long? Unitcostthreshold { get; set; }

    public decimal? Basefeeamount { get; set; }

    public long? Feetypeflags { get; set; }

    public DateTime? Effectivebegdate { get; set; }

    public DateTime? Effectiveenddate { get; set; }

    public long? Serviceclassnum { get; set; }

    public long? Feetypegroupnum { get; set; }
}
