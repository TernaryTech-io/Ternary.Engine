using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmsplitdepsegment
{
    public long Rcmsplitdepsegnum { get; set; }

    public string? Rcmsplitdepsegname { get; set; }

    public long? Tablenumber { get; set; }

    public long? Columnnumber { get; set; }

    public long? Depcolumnnumber { get; set; }

    public string? Depvalue { get; set; }
}
