using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Newdocumentfile
{
    public long Diskgroupnum { get; set; }

    public long Logicalplatternum { get; set; }

    public string Filepath { get; set; } = null!;

    public DateTime? Datemodified { get; set; }
}
