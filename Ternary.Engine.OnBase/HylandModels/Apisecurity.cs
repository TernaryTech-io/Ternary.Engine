using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Apisecurity
{
    public long Apisecuritynum { get; set; }

    public string? Apiusername { get; set; }

    public string? Apitoken { get; set; }

    public long? Apitypeflags { get; set; }

    public long? Mzapisecurity { get; set; }

    public long? Coreapisecurity { get; set; }

    public long? Disabled { get; set; }
}
