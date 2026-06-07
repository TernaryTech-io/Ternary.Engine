using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Processfontmap
{
    public long? Parsingmethod { get; set; }

    public string? Sourcefontfile { get; set; }

    public long? Sourcefontnum { get; set; }

    public string? Destfontfile { get; set; }

    public long? Destfontnum { get; set; }

    public long? Flags { get; set; }
}
