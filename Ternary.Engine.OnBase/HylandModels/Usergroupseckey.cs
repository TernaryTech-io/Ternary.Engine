using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Usergroupseckey
{
    public long Usergroupnum { get; set; }

    public long Keytypenum { get; set; }

    public long? Keysetnum { get; set; }

    public string Keyvaluechar { get; set; } = null!;

    public long? Keywordnum { get; set; }

    public long Seckeywordflag { get; set; }
}
