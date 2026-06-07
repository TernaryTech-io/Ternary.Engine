using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Logicalplatter
{
    public long Logicalplatternum { get; set; }

    public long Diskgroupnum { get; set; }

    public long? Platterpublished { get; set; }

    public long? Numexported { get; set; }

    public DateTime? Createtime { get; set; }

    public DateTime? Promotetime { get; set; }
}
