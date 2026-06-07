using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Postageusageinfo
{
    public long Pocustomernum { get; set; }

    public long? Postageleft { get; set; }

    public long? Avgpostageperday { get; set; }

    public long? Daysleft { get; set; }

    public string? Postagevalid { get; set; }
}
