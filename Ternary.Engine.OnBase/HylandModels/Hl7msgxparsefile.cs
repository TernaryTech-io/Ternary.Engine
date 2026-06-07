using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7msgxparsefile
{
    public long Parsefilenum { get; set; }

    public long? Hl7messagenum { get; set; }

    public long? Hl7destnum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Flags { get; set; }
}
