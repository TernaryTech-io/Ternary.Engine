using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7tablemap
{
    public long Hl7tablenum { get; set; }

    public string Hl7oldvalue { get; set; } = null!;

    public string? Hl7newvalue { get; set; }
}
