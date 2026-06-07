using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Casenote
{
    public long Casenotenum { get; set; }

    public long? Caseinstancenum { get; set; }

    public string? Casenotetitle { get; set; }

    public string? Casenotetext { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Createdusernum { get; set; }

    public DateTime? Modifieddate { get; set; }

    public long? Modifiedusernum { get; set; }
}
