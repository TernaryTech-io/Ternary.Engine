using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ihecodedvalue
{
    public long Ihecodedvaluenum { get; set; }

    public string? Hl7code { get; set; }

    public string? Hl7root { get; set; }

    public string? Description { get; set; }

    public long? Flags { get; set; }

    public long? Ihecodedvaluesetnum { get; set; }
}
