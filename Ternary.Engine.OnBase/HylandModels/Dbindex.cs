using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dbindex
{
    public long Dbnum { get; set; }

    public DateTime? Createtime { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public string? Filepath { get; set; }
}
