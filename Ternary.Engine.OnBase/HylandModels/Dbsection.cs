using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dbsection
{
    public long Dbsectionnum { get; set; }

    public string? Dbsectionname { get; set; }

    public string? Dbversion { get; set; }

    public long? Productenabled { get; set; }

    public long? Flags { get; set; }
}
