using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class M2wsitemapnode
{
    public long Mwnodenum { get; set; }

    public long? Parentnodenum { get; set; }

    public string? Mwnodetitle { get; set; }

    public string? Mwnodedescription { get; set; }

    public string? Mwnodeurl { get; set; }

    public long? Seqnum { get; set; }

    public string? Applicationname { get; set; }

    public long? Flags { get; set; }

    public long? Mwnodecolor { get; set; }

    public long? Mwnodefontcolor { get; set; }
}
