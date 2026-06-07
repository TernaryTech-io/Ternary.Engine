using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartxreviewqueue
{
    public long? Mrreviewqueuenum { get; set; }

    public long? Chtnum { get; set; }

    public DateTime? Availabledate { get; set; }

    public DateTime? Expiredate { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }
}
