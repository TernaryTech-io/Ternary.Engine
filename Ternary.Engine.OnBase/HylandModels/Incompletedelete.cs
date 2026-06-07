using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Incompletedelete
{
    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Physicalplatternum { get; set; }

    public string? Filepath { get; set; }

    public long? Offset { get; set; }

    public long? Filesize { get; set; }

    public long? Scrubmethod { get; set; }

    public long? Deletemethod { get; set; }

    public long? Itemnum { get; set; }

    public long? Fileremovereason { get; set; }

    public long? Flags { get; set; }
}
