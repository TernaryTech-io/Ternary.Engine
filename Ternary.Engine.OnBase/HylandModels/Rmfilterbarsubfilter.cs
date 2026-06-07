using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmfilterbarsubfilter
{
    public long Subfilterid { get; set; }

    public long? Filterbaritemid { get; set; }

    public long? Filterid { get; set; }

    public long? Sequenceid { get; set; }

    public string? Subfiltername { get; set; }
}
