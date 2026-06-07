using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimslbsearchlog
{
    public long? Lbimslognumfk { get; set; }

    public long? Constrainttype { get; set; }

    public long? Constraintnum { get; set; }

    public string? Constraintvalue { get; set; }

    public long? Constraintoperator { get; set; }
}
