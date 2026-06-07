using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chtextension
{
    public long? Chtnum { get; set; }

    public long? Medservicenum { get; set; }

    public long? Disposition { get; set; }

    public decimal? Totalcharges { get; set; }

    public string? Financialclass { get; set; }

    public long? Admitsource { get; set; }

    public long? Medpayornum { get; set; }

    public string? Chtdisposition { get; set; }

    public string? Admitsrc { get; set; }

    public long? Referphysnum { get; set; }

    public long? Primcarephysnum { get; set; }

    public string? Ptroom { get; set; }

    public long? Flags { get; set; }
}
