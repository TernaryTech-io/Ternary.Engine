using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Portallayout
{
    public long Layoutnum { get; set; }

    public string? Layoutname { get; set; }

    public long? Flags { get; set; }

    public string? Layoutdefinition { get; set; }
}
