using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fhirmimetype
{
    public long Fhirmimetypenum { get; set; }

    public string? Mimetype { get; set; }

    public long? Filetypenum { get; set; }

    public long? Flags { get; set; }
}
