using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mppublishstate
{
    public long Mppublishstatenum { get; set; }

    public long? Mppublishsrvrnum { get; set; }

    public long? Mpmedianum { get; set; }

    public string? Mppublishaddress { get; set; }

    public string? Mppublishstreamname { get; set; }

    public string? Mpdistaddressext { get; set; }

    public long? Streamtype { get; set; }

    public long? Publishstate { get; set; }

    public long? Itemorder { get; set; }

    public long? Flags { get; set; }
}
