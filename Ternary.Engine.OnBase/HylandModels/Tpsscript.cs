using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpsscript
{
    public long Tpsscriptnum { get; set; }

    public string? Tpsscriptname { get; set; }

    public string? Description { get; set; }

    public long? Itemnum { get; set; }

    public long? Tpsdeleted { get; set; }
}
