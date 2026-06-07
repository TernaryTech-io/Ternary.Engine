using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmworklist
{
    public long Rcmworklistnum { get; set; }

    public string? Rcmworklistname { get; set; }

    public long? Displaytype { get; set; }

    public long? Rcmqueue { get; set; }
}
