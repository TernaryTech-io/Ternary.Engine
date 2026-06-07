using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eismbclient
{
    public long Eisclientnum { get; set; }

    public long? Batchnum { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Ipaddress { get; set; }

    public string? Machinename { get; set; }

    public string? Externalclientname { get; set; }

    public long? Flags { get; set; }
}
