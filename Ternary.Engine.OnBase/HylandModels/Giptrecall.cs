using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Giptrecall
{
    public long Giptrecallnum { get; set; }

    public long? Gireportnum { get; set; }

    public DateTime? Girecalldate { get; set; }

    public long? Flags { get; set; }
}
