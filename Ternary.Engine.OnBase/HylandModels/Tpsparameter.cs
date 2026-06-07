using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpsparameter
{
    public long Tpsparameternum { get; set; }

    public long? Tpsscriptnum { get; set; }

    public long? Sequence { get; set; }

    public long? Paramdirection { get; set; }

    public string? Parametername { get; set; }

    public long? Datatype { get; set; }

    public string? Description { get; set; }

    public long? Parentparameternum { get; set; }
}
