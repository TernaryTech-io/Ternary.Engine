using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Useraccountseckey
{
    public long Keytypenum { get; set; }

    public long Usernum { get; set; }

    public long? Keysetnum { get; set; }

    public string Keyvaluechar { get; set; } = null!;

    public long? Keywordnum { get; set; }

    public long Seckeywordflag { get; set; }
}
