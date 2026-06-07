using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Storagetemplate
{
    public long Storagetemplatnum { get; set; }

    public string? Description { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Flags { get; set; }
}
