using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Analystworkrule
{
    public long Anlystwkrulenum { get; set; }

    public long? Usernum { get; set; }

    public string? Anlystwkrulename { get; set; }

    public long? Workruletype { get; set; }

    public long? Dptnum { get; set; }

    public long? Sorttype { get; set; }

    public long? Seqnum { get; set; }

    public long? Facilitynum { get; set; }

    public long? Admittypenum { get; set; }

    public long? Isdefault { get; set; }
}
