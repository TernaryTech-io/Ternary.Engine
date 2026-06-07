using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnaaccess
{
    public long Vnaaccessnum { get; set; }

    public long? Vnarevnum { get; set; }

    public long? Vnaaccesssrcnum { get; set; }

    public long? Vnaaccesssitenum { get; set; }

    public DateTime? Vnaaccessstarttime { get; set; }

    public DateTime? Vnaaccessendtime { get; set; }

    public DateTime? Vnaaccesstofrtime { get; set; }

    public long? Vnaaccesseventaction { get; set; }

    public long? Vnaaccesseventoutcome { get; set; }

    public long? Vnaaccessoutcomereason { get; set; }

    public long? Vnaaccesseventtypecode { get; set; }

    public long? Vnaaccesseventidcode { get; set; }
}
