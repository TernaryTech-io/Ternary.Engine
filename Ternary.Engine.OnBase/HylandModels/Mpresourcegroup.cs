using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpresourcegroup
{
    public long Mpresourcegrpnum { get; set; }

    public string? Mpresourcegroupname { get; set; }

    public long? Bandwidth { get; set; }

    public long? Flags { get; set; }
}
