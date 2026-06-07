using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Signaturedefinition
{
    public long Sigdefnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Flags { get; set; }

    public long? Hashtype { get; set; }

    public long? Signaturetypenum { get; set; }

    public string? Sigdefinitionname { get; set; }

    public string? Sigtext { get; set; }

    public long? Siglocationnum { get; set; }
}
