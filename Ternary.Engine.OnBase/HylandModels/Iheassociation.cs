using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Iheassociation
{
    public long Iheregistryobjnum { get; set; }

    public long? Ihecommunitynum { get; set; }

    public string? Iheassociationuuid { get; set; }

    public long? Ihesourcenum { get; set; }

    public long? Ihetargetnum { get; set; }

    public string? Ihesourceuuid { get; set; }

    public string? Ihetargetuuid { get; set; }

    public long? Iheassociationtype { get; set; }

    public long? Iheavailabilitystatus { get; set; }

    public DateTime? Creationdate { get; set; }

    public long? Flags { get; set; }
}
