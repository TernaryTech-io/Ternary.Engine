using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raauditcontractor
{
    public long Raauditornum { get; set; }

    public string? Rafriendlyname { get; set; }

    public long? Metaflags { get; set; }

    public string? Metaautoname { get; set; }

    public string? Claimautoname { get; set; }

    public string? Cdlabeltext { get; set; }

    public long? Burnthreshold { get; set; }

    public long? Flags { get; set; }
}
