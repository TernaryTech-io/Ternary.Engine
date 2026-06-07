using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ihefolder
{
    public long Iheregistryobjnum { get; set; }

    public long? Ihecommunitynum { get; set; }

    public string? Iheentryuuid { get; set; }

    public string? Iheuniqueid { get; set; }

    public string? Ihelogicalid { get; set; }

    public long? Iheversion { get; set; }

    public string? Ihepatientid { get; set; }

    public long? Iheavailabilitystatus { get; set; }

    public long? Ihelimitedmetadata { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Flags { get; set; }
}
