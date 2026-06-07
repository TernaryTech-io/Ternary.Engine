using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Codingflow
{
    public long Codingflownum { get; set; }

    public string? Codingflowname { get; set; }

    public long? Admittypenum { get; set; }

    public long? Flags { get; set; }

    public long? Facilitynum { get; set; }

    public long? Processpriority { get; set; }
}
