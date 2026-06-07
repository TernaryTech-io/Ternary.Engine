using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Uffieldvisual
{
    public long Ufformnum { get; set; }

    public long Formrevnum { get; set; }

    public string? Uffieldkey { get; set; }

    public string Uffieldvisualkey { get; set; } = null!;

    public long? Flags { get; set; }

    public long? Secured { get; set; }

    public long? Imageitemnum { get; set; }
}
