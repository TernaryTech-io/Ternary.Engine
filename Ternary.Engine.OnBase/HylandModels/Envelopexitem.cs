using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Envelopexitem
{
    public long Docnum { get; set; }

    public long Envelopenum { get; set; }

    public long? Doctype { get; set; }

    public long? Docrevnum { get; set; }
}
