using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Caseuserpref
{
    public long Caseuserprefnum { get; set; }

    public long? Casedefnum { get; set; }

    public long? Casetabnum { get; set; }

    public long? Usernum { get; set; }

    public string? Propname { get; set; }

    public string? Propvalue { get; set; }
}
