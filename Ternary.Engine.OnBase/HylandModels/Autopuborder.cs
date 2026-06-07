using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autopuborder
{
    public long Autopubordernum { get; set; }

    public string? Autopubordername { get; set; }

    public long? Formatnum { get; set; }

    public long? Customernum { get; set; }
}
