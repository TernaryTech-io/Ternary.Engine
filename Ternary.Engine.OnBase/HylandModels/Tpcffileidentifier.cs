using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpcffileidentifier
{
    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Itempagenum { get; set; }

    public string? Filepath { get; set; }

    public long? Diskgroupnum { get; set; }
}
