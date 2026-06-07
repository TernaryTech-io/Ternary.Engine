using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Applicationkey
{
    public long Appkeyid { get; set; }

    public Guid Appkeyguid { get; set; }

    public string Encryptedkey { get; set; } = null!;

    public string Iv { get; set; } = null!;

    public Guid Appguid { get; set; }

    public DateTimeOffset Createdate { get; set; }

    public DateTimeOffset Lastaccesseddate { get; set; }

    public bool Isactive { get; set; }

    public bool Compromised { get; set; }

    public bool Deprecated { get; set; }
}
