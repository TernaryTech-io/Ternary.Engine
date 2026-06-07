using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ufsetting
{
    public long Ufsettingnum { get; set; }

    public long? Ufsettingid { get; set; }

    public string? Ufsettingvalue { get; set; }

    public long? Flags { get; set; }
}
