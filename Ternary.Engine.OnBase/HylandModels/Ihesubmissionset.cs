using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ihesubmissionset
{
    public long Iheregistryobjnum { get; set; }

    public long? Ihecommunitynum { get; set; }

    public string? Iheentryuuid { get; set; }

    public string? Iheuniqueid { get; set; }

    public string? Ihepatientid { get; set; }

    public string? Ihesourceid { get; set; }

    public DateTime? Creationdate { get; set; }

    public long? Iheavailabilitystatus { get; set; }

    public long? Ihelimitedmetadata { get; set; }

    public long? Ihecontenttypecodenum { get; set; }

    public long? Flags { get; set; }
}
