using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ihecertificate
{
    public long Ihecertificatenum { get; set; }

    public long? Ihecommunitynum { get; set; }

    public string? Ihecertthumbprint { get; set; }

    public long? Ihecerttype { get; set; }
}
