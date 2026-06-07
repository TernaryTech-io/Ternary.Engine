using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapdestination
{
    public long Destinationnum { get; set; }

    public string? Destinationname { get; set; }

    public string? Client { get; set; }

    public string? Sapusername { get; set; }

    public string? Passwordval { get; set; }

    public string? Langaugeid { get; set; }

    public string? Saphostname { get; set; }

    public string? Systemnum { get; set; }

    public string? Gatewayhost { get; set; }

    public string? Gatewayservice { get; set; }

    public string? Senderid { get; set; }

    public long? Destinationtype { get; set; }

    public string? Targetsystem { get; set; }

    public string? Messageserver { get; set; }

    public string? Logingroup { get; set; }

    public long? Flags { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
