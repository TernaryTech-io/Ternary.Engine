using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Smitemdatapage
{
    public long Itemnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public string? Filepath { get; set; }

    public long? Filesize { get; set; }

    public long? Offset { get; set; }

    public long? Idpflags1 { get; set; }

    public long? Idpflags2 { get; set; }
}
