using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ftcatalog
{
    public long Catalognum { get; set; }

    public string? Catalogname { get; set; }

    public long? Diskgroupnum { get; set; }

    public string? Bhilite { get; set; }

    public string? Ehilite { get; set; }

    public string? Ftservername { get; set; }

    public string? Virtualdir { get; set; }

    public long? Ftcatflags { get; set; }
}
