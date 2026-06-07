using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Filechecksum
{
    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public string? Filepath { get; set; }

    public string? Checksumdata { get; set; }

    public long? Checksumtype { get; set; }

    public long? Flags { get; set; }

    public DateTime? Datestored { get; set; }

    public long? Generationsource { get; set; }
}
