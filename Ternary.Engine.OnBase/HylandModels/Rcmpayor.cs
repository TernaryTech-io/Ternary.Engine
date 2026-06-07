using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmpayor
{
    public long Rcmpayornum { get; set; }

    public string? Rcmpayorname { get; set; }

    public string? Rcmpayorgroupcode { get; set; }

    public long? Rcmdetailposting { get; set; }

    public string? Rcmfederaltaxid { get; set; }

    public long? Active { get; set; }
}
