using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Usergprintqueue
{
    public long Usergroupnum { get; set; }

    public long Pqueuenum { get; set; }

    public long? Defaultflags { get; set; }
}
