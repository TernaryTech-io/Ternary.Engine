using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Idpscope
{
    public long Idpscopenum { get; set; }

    public string? Idpscopename { get; set; }

    public long? Obblobnum { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }
}
