using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Racroirecipient
{
    public long? Roirecipientnum { get; set; }

    public string? Racroirecipientname { get; set; }

    public long? Burnthreshold { get; set; }

    public long? Outputflags { get; set; }

    public long? Metaflags { get; set; }

    public string? Metaautoname { get; set; }

    public string? Claimautoname { get; set; }

    public string? Cdlabeltext { get; set; }

    public long? Encryptflags { get; set; }
}
