using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartcodehist
{
    public long? Chtnum { get; set; }

    public long? Codingflownum { get; set; }

    public long? Codingqueuenum { get; set; }

    public long? Transituser { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Entrydate { get; set; }

    public DateTime? Finishdate { get; set; }

    public long? Lcnum { get; set; }

    public long? Statenum { get; set; }
}
