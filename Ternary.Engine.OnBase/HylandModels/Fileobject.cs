using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fileobject
{
    public long Filenum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public string? Filepath { get; set; }

    public DateTime? Datestored { get; set; }

    public long? Filesize { get; set; }
}
