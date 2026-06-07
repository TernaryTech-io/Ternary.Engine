using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmlogdetail
{
    public long Rcmlogdetailnum { get; set; }

    public long? Rcmlognum { get; set; }

    public string? Rcmfieldname { get; set; }

    public string? Valuebefore { get; set; }

    public string? Valueafter { get; set; }
}
