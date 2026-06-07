using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmactioncodeconfig
{
    public long Rcmactioncfgnum { get; set; }

    public long? Rcmactioncodenum { get; set; }

    public long? Rcmtransacttype { get; set; }

    public string? Rcmoverridecode { get; set; }

    public DateTime? Actioncfgeffectdate { get; set; }

    public DateTime? Actioncfgtermdate { get; set; }
}
