using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Folio
{
    public long Folionum { get; set; }

    public string? Folioname { get; set; }

    public long? Iconnum { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }
}
