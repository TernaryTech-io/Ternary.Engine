using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vrfile
{
    public long Verrepnum { get; set; }

    public long? Filenum { get; set; }

    public long? Filesize { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Numarchive { get; set; }

    public long? Numdocs { get; set; }

    public long? Seqnum { get; set; }

    public string? Vrfilepath { get; set; }
}
