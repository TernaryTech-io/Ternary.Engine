using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cryptocertderivedkey
{
    public long Cryptocertkeynum { get; set; }

    public long? Keyprovidernum { get; set; }

    public long? Dynkeytype { get; set; }

    public long? Dynkeycontext { get; set; }

    public long? Derivationtype { get; set; }

    public string? Certificatethumbprint { get; set; }

    public string? Initvectordata { get; set; }

    public string? Cryptokeyguid { get; set; }

    public long? Status { get; set; }

    public DateTime? Expiry { get; set; }

    public DateTime? Creationdate { get; set; }

    public DateTime? Escrowdate { get; set; }

    public long? Flags { get; set; }

    public long? Isolationid { get; set; }

    public long? Keylength { get; set; }

    public long? Cryptkeyprvdrnum { get; set; }
}
