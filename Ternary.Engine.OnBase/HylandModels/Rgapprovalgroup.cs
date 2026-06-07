using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rgapprovalgroup
{
    public long Approvalgroupnum { get; set; }

    public string? Approvalgroupname { get; set; }

    public long? Readinggroupnum { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Allowone { get; set; }
}
