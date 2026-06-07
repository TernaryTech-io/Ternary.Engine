using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cadscope
{
    public long Cadscopenum { get; set; }

    public string? Cadscopename { get; set; }

    public string? Cadscopepath { get; set; }

    public long? Flags { get; set; }
}
