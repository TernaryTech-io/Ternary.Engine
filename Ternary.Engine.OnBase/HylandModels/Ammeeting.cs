using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ammeeting
{
    public long Ammeetingnum { get; set; }

    public string? Ammeetingname { get; set; }

    public long? Ammeetingtypenum { get; set; }

    public DateTime? Ammeetingtime { get; set; }

    public string? Ammeetingloc { get; set; }

    public string? Ammeetingorgan { get; set; }

    public long? Amaistatustypenum { get; set; }

    public long? Amnextmtgtypenum { get; set; }

    public long? Ispublished { get; set; }

    public long? Flags { get; set; }

    public long? Isavailableforatg { get; set; }
}
