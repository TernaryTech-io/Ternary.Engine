using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autocdlabel
{
    public long Labelnum { get; set; }

    public string? Cdlabelname { get; set; }

    public string? Cdlabelpath { get; set; }

    public long? Labelflags { get; set; }
}
