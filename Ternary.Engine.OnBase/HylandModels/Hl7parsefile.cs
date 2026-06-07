using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7parsefile
{
    public long Parsefilenum { get; set; }

    public long Hl7messagenum { get; set; }

    public long Keykeytype { get; set; }

    public long Keynum { get; set; }

    public long? Flags { get; set; }
}
