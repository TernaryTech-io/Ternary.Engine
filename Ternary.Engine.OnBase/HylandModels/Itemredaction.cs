using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemredaction
{
    public long Sourceitemnum { get; set; }

    public long Sourcedocrevnum { get; set; }

    public long Destitemnum { get; set; }

    public DateTime? Redactiondate { get; set; }

    public long? Usernum { get; set; }
}
