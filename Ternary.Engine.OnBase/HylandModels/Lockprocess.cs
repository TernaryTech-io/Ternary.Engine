using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lockprocess
{
    public long Batchnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Locktime { get; set; }

    public long? Status { get; set; }

    public long? Locktype { get; set; }
}
