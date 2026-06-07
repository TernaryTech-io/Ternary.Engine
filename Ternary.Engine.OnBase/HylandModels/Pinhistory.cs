using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Pinhistory
{
    public long? Usernum { get; set; }

    public string? Pinhash { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
