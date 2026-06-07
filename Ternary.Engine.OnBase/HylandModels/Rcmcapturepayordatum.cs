using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmcapturepayordatum
{
    public long Payoritemnum { get; set; }

    public long? Parentpayoritemnum { get; set; }

    public string? Payorname { get; set; }

    public string? Payornum { get; set; }

    public long? Status { get; set; }

    public string? Aggregateguid { get; set; }

    public string? Fedtaxid { get; set; }
}
