using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Uitab
{
    public long Tabnum { get; set; }

    public long? Uiprefnum { get; set; }

    public long? Sequencenum { get; set; }

    public long? Tabcolor { get; set; }

    public string? Tabtext { get; set; }

    public long? Flags { get; set; }

    public long? Chtrevnum { get; set; }
}
