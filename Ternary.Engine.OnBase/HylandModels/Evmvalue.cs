using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Evmvalue
{
    public long Evmvaluenum { get; set; }

    public long? Evmsetnum { get; set; }

    public long? Flags { get; set; }

    public long? Evdefinition { get; set; }

    public string? Evvalue { get; set; }

    public long? Referencetype { get; set; }

    public long? Referenceitem { get; set; }

    public long? Cryptotype { get; set; }

    public string? Initvectordata { get; set; }
}
