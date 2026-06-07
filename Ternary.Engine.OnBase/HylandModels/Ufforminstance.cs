using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ufforminstance
{
    public long? Itemnum { get; set; }

    public long? Ufformnum { get; set; }

    public long? Formrevnum { get; set; }

    public long? Ufinstancetype { get; set; }

    public long? Ufitemtype { get; set; }

    public long? Ufobjectnum { get; set; }

    public string? Uflang { get; set; }

    public long? Origformrevnum { get; set; }

    public long? Prevformrevnum { get; set; }
}
