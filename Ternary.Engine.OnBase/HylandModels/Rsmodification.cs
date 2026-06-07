using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rsmodification
{
    public long Rsmodnum { get; set; }

    public long? Modtypenum { get; set; }

    public string? Modreasonothr { get; set; }

    public long? Instrumentnum { get; set; }

    public long? Modinstrid { get; set; }

    public long? Seqnum { get; set; }

    public long? Instrumenttype { get; set; }
}
