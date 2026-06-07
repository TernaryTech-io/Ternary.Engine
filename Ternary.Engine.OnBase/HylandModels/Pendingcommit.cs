using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Pendingcommit
{
    public long Pendcommitnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Batchtype { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public DateTime? Requestdate { get; set; }

    public DateTime? Completeddate { get; set; }

    public long? Status { get; set; }

    public string? Commitdisposition { get; set; }
}
