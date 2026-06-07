using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpcfdocerror
{
    public long Itemnum { get; set; }

    public long? Errorcount { get; set; }

    public DateTime? Lasterrordate { get; set; }

    public string? Lasterrormessage { get; set; }

    public long? Lasterrorclass { get; set; }

    public long? Lasterrorcode { get; set; }
}
