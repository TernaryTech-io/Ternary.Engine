using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class M2wchartseries
{
    public long Chartseriesnum { get; set; }

    public long? Webpartnum { get; set; }

    public string? Seriescolor { get; set; }

    public string? Seriesname { get; set; }

    public long? Orientationcode { get; set; }

    public long? Chartstylecode { get; set; }

    public long? Flags { get; set; }
}
