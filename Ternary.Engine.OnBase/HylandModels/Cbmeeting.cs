using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cbmeeting
{
    public long Meetnum { get; set; }

    public string? Hostmeetnum { get; set; }

    public long? Schedmeetnum { get; set; }

    public DateTime? Meettime { get; set; }

    public long? Status { get; set; }
}
