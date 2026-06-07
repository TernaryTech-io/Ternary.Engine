using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Idptcconfig
{
    public long Idptcconfignum { get; set; }

    public long? Flags { get; set; }

    public long? Cryptotype { get; set; }

    public string? Initvectordata { get; set; }

    public string? Idpurl { get; set; }

    public string? Tenant { get; set; }

    public string? Providergroup { get; set; }

    public string? Clientid { get; set; }

    public string? Clientsecret { get; set; }

    public string? Grantscope { get; set; }

    public string? Redirecturi { get; set; }

    public string? Challengemethod { get; set; }
}
