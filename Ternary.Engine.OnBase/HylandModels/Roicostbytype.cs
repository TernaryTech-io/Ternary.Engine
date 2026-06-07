using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roicostbytype
{
    public long Roirequesttypenum { get; set; }

    public string? Roirequestname { get; set; }

    public long? Costperpage { get; set; }

    public long? Flags { get; set; }

    public long? Sortkeytypenum { get; set; }

    public long? Facilitynum { get; set; }

    public string? Rtdisplayname { get; set; }

    public long? Freepages { get; set; }

    public long? Defpricingpolicynum { get; set; }
}
