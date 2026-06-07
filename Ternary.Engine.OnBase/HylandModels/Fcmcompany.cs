using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmcompany
{
    public long Fccompanynum { get; set; }

    public string? Fcdescription { get; set; }

    public long? Fcentitynum { get; set; }

    public long? Active { get; set; }

    public long? Flags { get; set; }

    public long? Parentcompanynum { get; set; }
}
