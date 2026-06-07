using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Siginstance
{
    public long Siginstancenum { get; set; }

    public long? Sigfieldnum { get; set; }

    public long? Itemnum { get; set; }

    public string? Siginstancehash { get; set; }

    public DateTime? Sigdate { get; set; }
}
