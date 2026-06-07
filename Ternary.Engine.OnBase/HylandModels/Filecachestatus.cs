using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Filecachestatus
{
    public long? Lclcloudcachenum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public string? Filepath { get; set; }

    public DateTime? Timecached { get; set; }

    public DateTime? Lastaccessed { get; set; }

    public long? Offset { get; set; }

    public long? Filesize { get; set; }
}
