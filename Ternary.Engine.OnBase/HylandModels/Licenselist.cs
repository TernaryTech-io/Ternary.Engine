using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Licenselist
{
    public long Licenselistnum { get; set; }

    public string? Licenselistname { get; set; }

    public long? Flags { get; set; }
}
