using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bscsnapshotdef
{
    public long Bscsnapshotdefnum { get; set; }

    public string? Bscsnapshotname { get; set; }

    public string? Odbcdatasource { get; set; }

    public string? Odbcusername { get; set; }

    public string? Odbcencyptedpw { get; set; }

    public long? Flags { get; set; }
}
