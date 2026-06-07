using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medbanner
{
    public long Medbannernum { get; set; }

    public long? Itemnum { get; set; }

    public string? Banneridentifier { get; set; }

    public string? Bannerdescription { get; set; }

    public long? Isdefault { get; set; }
}
