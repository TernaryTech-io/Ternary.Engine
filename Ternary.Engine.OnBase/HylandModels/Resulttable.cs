using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Resulttable
{
    public long Offset { get; set; }

    public long Jobnum { get; set; }

    public long Itemnum { get; set; }

    public long? Foundlinenum { get; set; }

    public long? Foundpagenum { get; set; }

    public long? Searchlen { get; set; }

    public long? Status { get; set; }

    public string? Textline { get; set; }

    public long? Searchheight { get; set; }
}
