using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eismbfault
{
    public long Eisfaultnum { get; set; }

    public long? Eismsgnum { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Errormsg { get; set; }

    public long? Obblobnum { get; set; }

    public long? Flags { get; set; }
}
