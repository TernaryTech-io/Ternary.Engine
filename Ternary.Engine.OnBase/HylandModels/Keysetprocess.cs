using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Keysetprocess
{
    public long Parsefilenum { get; set; }

    public string? Keydelimiter { get; set; }

    public string? Keyseparator { get; set; }

    public long? Flags { get; set; }
}
