using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Verityftserver
{
    public long Vftsrvrnum { get; set; }

    public string? Vftsrvralias { get; set; }

    public string? Vftsrvrhostname { get; set; }

    public long? Vftsrvrport { get; set; }

    public long? Vftsrvrflags { get; set; }
}
