using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cryptocertbasedkey
{
    public long Managedkeynum { get; set; }

    public long? Derivationtype { get; set; }

    public string? Certificatethumbprint { get; set; }

    public string? Initvectordata { get; set; }

    public long? Flags { get; set; }
}
