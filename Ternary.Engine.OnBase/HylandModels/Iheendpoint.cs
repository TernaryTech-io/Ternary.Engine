using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Iheendpoint
{
    public long Iheendpointnum { get; set; }

    public long? Ihecommunitynum { get; set; }

    public long? Endpointtype { get; set; }

    public long? Protocoltype { get; set; }

    public string? Baseurl { get; set; }

    public long? Serverport { get; set; }

    public string? Apppath { get; set; }

    public long? Flags { get; set; }

    public long? Ihecertificatenum { get; set; }

    public string? Ihedisplayname { get; set; }

    public string? Ihecertthumbprint { get; set; }
}
