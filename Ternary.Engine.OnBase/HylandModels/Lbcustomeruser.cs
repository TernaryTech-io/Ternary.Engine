using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbcustomeruser
{
    public long Customernum { get; set; }

    public string Externaluserid { get; set; } = null!;

    public string? Externalusername { get; set; }

    public long? Flags { get; set; }
}
