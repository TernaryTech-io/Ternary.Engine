using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dashboardaction
{
    public long Dashboardactnum { get; set; }

    public long? Dashboardnum { get; set; }

    public string? Dashboarditemname { get; set; }

    public long? Actiontype { get; set; }

    public long? Dashboardcaption { get; set; }

    public long? Displayorder { get; set; }

    public long? Flags { get; set; }

    public string? Caption { get; set; }
}
