using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwdeposittype
{
    public long Rcmtwdepostypenum { get; set; }

    public string? Rcmtwdeposittypename { get; set; }

    public string? Rcmtransactioncodetype { get; set; }

    public string? Rcmpayerid { get; set; }

    public string? Rcmpayorname { get; set; }

    public string? Rcmuserinitials { get; set; }

    public long? Rcmautodeactivate { get; set; }

    public string? Rcmdepositcomments { get; set; }
}
