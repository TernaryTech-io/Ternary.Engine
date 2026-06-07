using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dodfield
{
    public long Dodfieldsnum { get; set; }

    public long? Dodsitenum { get; set; }

    public string? Dodcontenttypename { get; set; }

    public string? Dodfieldname { get; set; }

    public long? Doddisplaytype { get; set; }

    public long? Flags { get; set; }
}
