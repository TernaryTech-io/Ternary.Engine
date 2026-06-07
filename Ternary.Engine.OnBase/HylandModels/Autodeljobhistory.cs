using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autodeljobhistory
{
    public long Autodeljobhistnum { get; set; }

    public long? Autodelrulenum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Physicalplatternum { get; set; }

    public DateTime? Timequeued { get; set; }

    public DateTime? Timefinished { get; set; }

    public long? Approvedby { get; set; }
}
