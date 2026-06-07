using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmdmconfig
{
    public long? Flags { get; set; }

    public long? Schedtasknum { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }
}
