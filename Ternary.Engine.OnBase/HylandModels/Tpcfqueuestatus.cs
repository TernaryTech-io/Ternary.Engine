using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpcfqueuestatus
{
    public long? Lastitemnum { get; set; }

    public long? Lastpriority { get; set; }

    public long? Queuestatus { get; set; }

    public DateTime? Dateadded { get; set; }
}
