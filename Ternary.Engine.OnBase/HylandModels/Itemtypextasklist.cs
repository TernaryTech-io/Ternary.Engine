using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemtypextasklist
{
    public long Itemtypenum { get; set; }

    public long Tasklistnum { get; set; }

    public long? Flags { get; set; }

    public long? Wfcontenttype { get; set; }
}
