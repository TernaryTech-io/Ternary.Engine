using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Licusage
{
    public DateTime? Logdate { get; set; }

    public long? Workstationnum { get; set; }

    public long? Producttype { get; set; }

    public long? Usagecount { get; set; }
}
