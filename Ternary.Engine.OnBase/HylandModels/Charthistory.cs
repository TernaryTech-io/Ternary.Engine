using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Charthistory
{
    public long? Chtnum { get; set; }

    public string? Prevchtidnumber { get; set; }

    public string? Actionname { get; set; }

    public string? Hl7root { get; set; }
}
