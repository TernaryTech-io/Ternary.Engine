using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cryptoencryptedkey
{
    public long Managedkeynum { get; set; }

    public long? Cryptotype { get; set; }

    public string? Initvectordata { get; set; }

    public string? Encryptkeydata { get; set; }

    public long? Flags { get; set; }
}
