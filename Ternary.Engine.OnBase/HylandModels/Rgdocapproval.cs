using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rgdocapproval
{
    public long Rgdocumentnum { get; set; }

    public long Approvalgroupnum { get; set; }

    public long Usernum { get; set; }

    public long? Allowone { get; set; }

    public DateTime? Decisiondate { get; set; }

    public long? Status { get; set; }
}
