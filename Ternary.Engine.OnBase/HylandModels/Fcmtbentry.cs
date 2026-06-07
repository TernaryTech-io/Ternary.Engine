using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmtbentry
{
    public long Fctbentrynum { get; set; }

    public string? Fcaccountcode { get; set; }

    public decimal? Fcbalance { get; set; }

    public long? Fctbimportnum { get; set; }
}
