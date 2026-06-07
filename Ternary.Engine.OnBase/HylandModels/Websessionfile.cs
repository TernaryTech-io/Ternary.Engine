using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Websessionfile
{
    public long ApiSeshandle { get; set; }

    public long? ApiQueryhandle { get; set; }

    public long ApiItemnum { get; set; }

    public long ApiRevision { get; set; }

    public string ApiRendition { get; set; } = null!;

    public long ApiPagenum { get; set; }

    public string? ApiMimetype { get; set; }

    public long? ApiOverlay { get; set; }

    public string? ApiFilefullpath { get; set; }

    public long? ApiBrokerport { get; set; }
}
