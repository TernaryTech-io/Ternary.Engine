using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Insightevent
{
    public long Itemnum { get; set; }

    public long? Actionnum { get; set; }

    public DateTime? Eventdate { get; set; }

    public DateTime? Laststatuschangedate { get; set; }

    public long Itemtypenum { get; set; }

    public long? Status { get; set; }
}
