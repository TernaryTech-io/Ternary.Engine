using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcfragment
{
    public long Dctemplatenum { get; set; }

    public long Fragmentid { get; set; }

    public string? Fragmentname { get; set; }

    public long? Bindtype { get; set; }
}
