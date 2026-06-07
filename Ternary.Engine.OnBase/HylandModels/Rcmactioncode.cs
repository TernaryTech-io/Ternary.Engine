using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmactioncode
{
    public long Rcmactionnum { get; set; }

    public long? Rcmtransacttype { get; set; }

    public string? Rcmoverridecode { get; set; }

    public string? Rcmcomments { get; set; }
}
