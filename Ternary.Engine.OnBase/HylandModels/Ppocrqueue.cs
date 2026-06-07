using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ppocrqueue
{
    public long? Ppjobnum { get; set; }

    public long? Registernum { get; set; }

    public string? Inputfile { get; set; }

    public string? Outputpath { get; set; }

    public long? Flags { get; set; }
}
