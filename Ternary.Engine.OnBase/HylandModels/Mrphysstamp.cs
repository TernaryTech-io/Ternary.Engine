using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrphysstamp
{
    public long? Usernum { get; set; }

    public long? Itemnum { get; set; }

    public long? Ccstatus { get; set; }

    public DateTime? Dateadded { get; set; }

    public string? Rejectreason { get; set; }
}
