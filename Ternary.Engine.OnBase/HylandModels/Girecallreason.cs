using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Girecallreason
{
    public long Girecallreasonnum { get; set; }

    public long? Giptrecallnum { get; set; }

    public long? Girecallrsntypnum { get; set; }

    public string? Recallreason { get; set; }

    public long? Flags { get; set; }
}
