using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Casedefinition
{
    public long Casedefnum { get; set; }

    public string? Casedefname { get; set; }

    public long? Keysetnum { get; set; }

    public long? Taborientation { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Headerformat { get; set; }

    public string? Autonamestring { get; set; }

    public long? Flags { get; set; }
}
