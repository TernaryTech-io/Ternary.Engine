using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docretprocess
{
    public long Parsefilenum { get; set; }

    public long? Lcnum { get; set; }

    public long? Vbscriptnum { get; set; }

    public string? Processorpath { get; set; }

    public long? Flags { get; set; }
}
