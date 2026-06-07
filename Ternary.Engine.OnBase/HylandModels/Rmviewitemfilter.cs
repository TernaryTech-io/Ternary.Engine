using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmviewitemfilter
{
    public long Viewitemfilterid { get; set; }

    public long? Addlistfilterid { get; set; }

    public long? Filterid { get; set; }

    public string? Linkedaddress { get; set; }

    public string? Sourceaddress { get; set; }

    public long? Viewitemid { get; set; }

    public long? Flags { get; set; }

    public long? Atlviewastype { get; set; }

    public long? Viewastype { get; set; }
}
