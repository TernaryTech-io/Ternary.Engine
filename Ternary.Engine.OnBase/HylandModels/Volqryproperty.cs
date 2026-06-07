using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Volqryproperty
{
    public long Fieldnum { get; set; }

    public string? Displayname { get; set; }

    public string? Jointablename { get; set; }

    public string? Joincolumnname { get; set; }

    public long? Columnwidth { get; set; }
}
