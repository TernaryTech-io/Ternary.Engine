using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vendornarchive
{
    public long Vendornarchivenum { get; set; }

    public string? Archivename { get; set; }

    public long? Flags { get; set; }

    public long? Vendortype { get; set; }
}
