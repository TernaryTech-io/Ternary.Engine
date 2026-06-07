using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rgusergrouplog
{
    public long? Readinggroupnum { get; set; }

    public long? Usergroupnum { get; set; }

    public DateTime? Dateactivated { get; set; }

    public DateTime? Datedeactivated { get; set; }

    public long? Status { get; set; }
}
