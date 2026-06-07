using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7table
{
    public long Hl7tablenum { get; set; }

    public string? Hl7tablename { get; set; }

    public long? Flags { get; set; }
}
