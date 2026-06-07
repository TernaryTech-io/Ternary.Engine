using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835n4
{
    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public string? Loopid { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? N401city { get; set; }

    public string? N402statecode { get; set; }

    public string? N403zipcode { get; set; }

    public string? N404countrycode { get; set; }

    public string? N407countrysubcode { get; set; }
}
