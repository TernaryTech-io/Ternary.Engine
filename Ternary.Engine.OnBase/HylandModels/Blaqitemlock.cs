using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Blaqitemlock
{
    public long Blaqprocessnum { get; set; }

    public long Batchnum { get; set; }

    public long Itemnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Lockdate { get; set; }

    public long? Workstationnum { get; set; }
}
