using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Signaturetype
{
    public long Signaturetypenum { get; set; }

    public string? Sigtypename { get; set; }

    public long? Flags { get; set; }
}
