using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrcase
{
    public long Casenum { get; set; }

    public long? Usernum { get; set; }

    public long? Mpinum { get; set; }

    public string? Casename { get; set; }

    public long? Casecolor { get; set; }

    public long? Ispublic { get; set; }

    public long? Mrcasetype { get; set; }
}
