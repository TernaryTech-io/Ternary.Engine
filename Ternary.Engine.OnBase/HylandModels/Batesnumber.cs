using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Batesnumber
{
    public long Diskgroupnum { get; set; }

    public long Logicalplatternum { get; set; }

    public string Filepath { get; set; } = null!;

    public long Physicalpagenum { get; set; }

    public string? Batesnumber1 { get; set; }
}
