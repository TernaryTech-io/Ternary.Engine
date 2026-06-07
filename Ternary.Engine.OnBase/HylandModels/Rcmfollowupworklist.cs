using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmfollowupworklist
{
    public long? Rcmworklistnum { get; set; }

    public string? Rcmworklistname { get; set; }

    public string? Rcmsource { get; set; }

    public long? Active { get; set; }

    public long? Rcmdataprovidertype { get; set; }
}
