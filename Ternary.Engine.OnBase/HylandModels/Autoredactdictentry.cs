using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autoredactdictentry
{
    public long? Autoredactdictnum { get; set; }

    public long? Seqnum { get; set; }

    public string? Dictterm { get; set; }

    public long? Flags { get; set; }

    public long? Matchtolerance { get; set; }
}
