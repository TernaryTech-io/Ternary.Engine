using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmsubfilter
{
    public long Subfilterid { get; set; }

    public long? Filterid { get; set; }

    public long? Parentid { get; set; }

    public long? Parenttype { get; set; }

    public long? Sequenceid { get; set; }

    public string? Subfiltername { get; set; }
}
