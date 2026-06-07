using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rsinstrrestlist
{
    public long? Instrumentnum { get; set; }

    public long? Restaccesslevel { get; set; }

    public DateTime? Restaccessbeg { get; set; }

    public DateTime? Restaccessend { get; set; }

    public DateTime? Transactiondate { get; set; }

    public long? Restlistaction { get; set; }

    public long? Usernum { get; set; }
}
