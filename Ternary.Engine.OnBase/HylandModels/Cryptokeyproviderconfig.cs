using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cryptokeyproviderconfig
{
    public long Cryptkeyprvdrnum { get; set; }

    public string? Keyprovidername { get; set; }

    public string? Keyproviderprefix { get; set; }

    public long? Keyprovidernum { get; set; }

    public long? Dynkeytype { get; set; }

    public long? Isdefault { get; set; }

    public long? Keylength { get; set; }

    public string? Keyparams { get; set; }

    public long? Keyparamsfmt { get; set; }

    public long? Expirydays { get; set; }

    public long? Flags { get; set; }

    public long? Isolationid { get; set; }

    public long? Rotationextent { get; set; }

    public long? Dynkeycontext { get; set; }
}
