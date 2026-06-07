using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmmobilecomponent
{
    public long Mobilecomponentid { get; set; }

    public long? Componenttype { get; set; }

    public long? Parentid { get; set; }

    public long? Flags { get; set; }

    public string? Mobilecomptitle { get; set; }

    public long? Rmdescriptionid { get; set; }

    public long? Seqnum { get; set; }

    public long? Primarycomponentid { get; set; }
}
