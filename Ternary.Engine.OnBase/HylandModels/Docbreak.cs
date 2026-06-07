using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docbreak
{
    public long Itemtypenum { get; set; }

    public string? Fieldname { get; set; }

    public long? Breaktype { get; set; }

    public long? Breakoffset { get; set; }

    public long? Breakcondition { get; set; }
}
