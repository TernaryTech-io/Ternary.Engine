using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Externalauth
{
    public long Externalauthnum { get; set; }

    public string? Externalauthname { get; set; }

    public long? Flags { get; set; }

    public string? Authdllname { get; set; }

    public string? Authclsid { get; set; }

    public string? Authdllversion { get; set; }

    public long? Capabilitiesflags { get; set; }
}
