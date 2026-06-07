using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mfincident
{
    public long? Foldernum { get; set; }

    public string? Mfincidentname { get; set; }

    public long? Mfincidenttypenum { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Mfflag { get; set; }
}
