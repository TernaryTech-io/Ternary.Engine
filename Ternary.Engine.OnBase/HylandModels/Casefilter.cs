using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Casefilter
{
    public long Casedefnum { get; set; }

    public long Keytypenum { get; set; }

    public long? Displaytype { get; set; }

    public long? Sequence { get; set; }
}
