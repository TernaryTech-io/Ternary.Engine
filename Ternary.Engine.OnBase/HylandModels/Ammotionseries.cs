using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ammotionseries
{
    public long Ammotionseriesnum { get; set; }

    public long? Ammeetingnum { get; set; }

    public long? Motiontypenum { get; set; }

    public string? Defaulttext { get; set; }

    public long? Amvotetype { get; set; }

    public long? Ammovedby { get; set; }

    public long? Amsecondedby { get; set; }

    public long? Ammtnrslttypenum { get; set; }

    public DateTime? Ameventtime { get; set; }

    public long? Flags { get; set; }
}
