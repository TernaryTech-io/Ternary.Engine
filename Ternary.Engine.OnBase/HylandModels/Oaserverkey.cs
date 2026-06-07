using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Oaserverkey
{
    public string Oaservername { get; set; } = null!;

    public long Keytypenum { get; set; }

    public string? Oapropertyname { get; set; }
}
