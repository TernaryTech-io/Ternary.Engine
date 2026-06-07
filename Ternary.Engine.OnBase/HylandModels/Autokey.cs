using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autokey
{
    public long Keytypenum { get; set; }

    public long Foldertypenum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Keytypesetflags { get; set; }

    public long? Parentflag { get; set; }

    public long? Sequence { get; set; }

    public long? Itiflag { get; set; }

    public string? Keyvaluechar { get; set; }

    public long? Flags { get; set; }
}
