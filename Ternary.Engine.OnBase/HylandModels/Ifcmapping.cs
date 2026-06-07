using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ifcmapping
{
    public long Ifcmappingnum { get; set; }

    public long? Ufformnum { get; set; }

    public long? Ifccollformtype { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Ifcverifformtype { get; set; }

    public long? Flags { get; set; }
}
