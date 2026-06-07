using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mppublishserver
{
    public long Mppublishsrvrnum { get; set; }

    public string? Mppublishservername { get; set; }

    public string? Mpdisplayname { get; set; }

    public string? Mpaddress { get; set; }

    public string? Mpstoragelocation { get; set; }

    public long? Flags { get; set; }
}
