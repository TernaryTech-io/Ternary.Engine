using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmaccount
{
    public long Fcaccountnum { get; set; }

    public string? Fcaccountcode { get; set; }

    public long? Fccompanynum { get; set; }

    public string? Fcdescription { get; set; }

    public long? Active { get; set; }

    public long? Flags { get; set; }

    public long? Fcaccttypenum { get; set; }
}
