using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eisexternalauth
{
    public long Eisextrnalauthnum { get; set; }

    public long? Eisexternalauthtype { get; set; }

    public string? Username { get; set; }

    public string? Encryptedpassword { get; set; }

    public long? Cryptotype { get; set; }

    public string? Initvectordata { get; set; }

    public long? Flags { get; set; }
}
