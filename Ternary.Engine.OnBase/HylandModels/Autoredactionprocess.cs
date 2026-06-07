using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autoredactionprocess
{
    public long Autoredactprocnum { get; set; }

    public string? Redactprocname { get; set; }

    public long? Flags { get; set; }

    public long? Itemnum { get; set; }
}
