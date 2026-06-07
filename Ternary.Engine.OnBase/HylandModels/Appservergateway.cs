using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Appservergateway
{
    public long Appservgatewaynum { get; set; }

    public string? Appservgatewayname { get; set; }

    public long? Autorefreshdocs { get; set; }

    public long? Pullinterval { get; set; }

    public long? Expiretime { get; set; }

    public long? Maxdiskcachesize { get; set; }

    public long? Flags { get; set; }
}
