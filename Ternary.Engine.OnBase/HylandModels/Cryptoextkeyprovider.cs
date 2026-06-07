using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cryptoextkeyprovider
{
    public long Keyprovidernum { get; set; }

    public string? Keyprovidername { get; set; }

    public string? Keyproviderdesc { get; set; }

    public string? Keyproviderguid { get; set; }

    public string? Keyproviderprefix { get; set; }

    public long? Keyproviderinttype { get; set; }

    public string? Interfacecontractver { get; set; }

    public string? Keyprovidersettings { get; set; }

    public long? Flags { get; set; }
}
