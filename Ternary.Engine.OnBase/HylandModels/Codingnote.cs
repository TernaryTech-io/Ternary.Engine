using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Codingnote
{
    public long Codingnotenum { get; set; }

    public string? Codingnotetitle { get; set; }

    public long? Chtnum { get; set; }

    public long? Creatorusernum { get; set; }

    public DateTime? Entrydate { get; set; }

    public long? Itemnum { get; set; }

    public long? Itempagenum { get; set; }

    public long? Notexposcol { get; set; }

    public long? Noteyposrow { get; set; }

    public string? Entrytext { get; set; }

    public long? Userprivilege { get; set; }

    public long? Disposition { get; set; }

    public long? Flags { get; set; }

    public string? Responsetext { get; set; }

    public long? Analystnum { get; set; }
}
