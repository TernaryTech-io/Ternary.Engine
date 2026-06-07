using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cryptokey
{
    public long Managedkeynum { get; set; }

    public long? Cryptkeyprvdrnum { get; set; }

    public string? Keylocator { get; set; }

    public long? Parentmanagedkeynum { get; set; }

    public string? Externalkeyidentifier { get; set; }

    public long? Status { get; set; }

    public DateTime? Creationdate { get; set; }

    public DateTime? Expiredate { get; set; }

    public DateTime? Escrowdate { get; set; }

    public long? Keylength { get; set; }

    public long? Flags { get; set; }
}
