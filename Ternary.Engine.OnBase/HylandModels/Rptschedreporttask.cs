using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rptschedreporttask
{
    public long? Schedtasknum { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Fullfilepath { get; set; }

    public string? Networklocation { get; set; }

    public long? Flags { get; set; }
}
