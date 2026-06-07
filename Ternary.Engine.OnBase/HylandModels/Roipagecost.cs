using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roipagecost
{
    public long Stateid { get; set; }

    public long? Maxcostperpage { get; set; }

    public long? Flags { get; set; }

    public decimal? Roiflatfee { get; set; }
}
