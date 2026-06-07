using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Keyencryptionkey
{
    public int Kekid { get; set; }

    public string Encryptedkey { get; set; } = null!;

    public long Kekkekid { get; set; }

    public DateTimeOffset Createdate { get; set; }

    public bool Compromised { get; set; }
}
