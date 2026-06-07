using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemtypegroup
{
    public long Itemtypegroupnum { get; set; }

    public string? Itemtypegroupname { get; set; }

    public long? Inuse { get; set; }

    public long? Itemtypegroupused { get; set; }

    public long? Numrows { get; set; }

    public long? Docsourceflag { get; set; }

    public string? Dmasourcename { get; set; }

    public long? Dmaconnectflag { get; set; }

    public string? Dmausername { get; set; }

    public string? Dmauserpassword { get; set; }

    public string? Dmasystemname { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Flags { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
