using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpdistserver
{
    public long Mpdistservernum { get; set; }

    public string? Mpdistservername { get; set; }

    public string? Mpappserveraddress { get; set; }

    public string? Mpcdnaddress { get; set; }

    public string? Mpcdnvirtualdir { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
