using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Initvector
{
    public long Initvectornum { get; set; }

    public string? Initvectordata { get; set; }

    public long? Encryptdatatype { get; set; }

    public long? Dataidentifier1 { get; set; }

    public long? Dataidentifier2 { get; set; }
}
