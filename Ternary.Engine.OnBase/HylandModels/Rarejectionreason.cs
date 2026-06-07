using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rarejectionreason
{
    public long Rarejectreasonnum { get; set; }

    public string? Rejectionreasontext { get; set; }

    public string? Rarejectreasoncode { get; set; }

    public long? Raclaimtype { get; set; }

    public long? Rafacilitytype { get; set; }

    public long? Parentnum { get; set; }

    public long? Visibility { get; set; }

    public long? Flags { get; set; }
}
