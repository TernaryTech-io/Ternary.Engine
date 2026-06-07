using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmprocessinglogdet
{
    public long Proclogdetnum { get; set; }

    public long? Rcmprocesslognum { get; set; }

    public long? Batchnum { get; set; }

    public string? Rcmfieldname { get; set; }

    public string? Valuebefore { get; set; }

    public string? Valueafter { get; set; }

    public long? Rcmrownum { get; set; }

    public string? Rcmtablename { get; set; }
}
