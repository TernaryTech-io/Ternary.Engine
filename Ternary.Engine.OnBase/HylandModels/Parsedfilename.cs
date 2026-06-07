using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Parsedfilename
{
    public long Batchnum { get; set; }

    public string Filepath { get; set; } = null!;

    public long? Logicalplatternum { get; set; }

    public long? Diskgroupnum { get; set; }
}
