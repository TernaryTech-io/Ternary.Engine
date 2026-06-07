using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Iaprovider
{
    public long? Providerhsinum { get; set; }

    public string? Providername { get; set; }

    public string? Providerurl { get; set; }

    public string? Phonenum { get; set; }

    public long? Consentitemnum { get; set; }

    public long? Consentexpiry { get; set; }

    public long? Flags { get; set; }
}
