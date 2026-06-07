using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartchangehist
{
    public long? Chtnum { get; set; }

    public long? Changeusernum { get; set; }

    public DateTime? Changedate { get; set; }

    public long? Changetype { get; set; }

    public long? Prevusernum { get; set; }

    public long? Newusernum { get; set; }
}
