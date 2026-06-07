using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Encryptionkey
{
    public long Encryptkeynum { get; set; }

    public string? Encryptkeydata { get; set; }

    public long? Encryptdatatype { get; set; }

    public long? Dataidentifier1 { get; set; }

    public long? Dataidentifier2 { get; set; }

    public long? Flags { get; set; }

    public long? Encryptiontype { get; set; }

    public long? Cryptotype { get; set; }
}
