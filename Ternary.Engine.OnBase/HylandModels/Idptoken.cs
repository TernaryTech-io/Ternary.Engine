using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Idptoken
{
    public long Idptokennum { get; set; }

    public long? Obblobnum { get; set; }

    public long? Idpclientnum { get; set; }

    public long? Usernum { get; set; }

    public string? Tokenkey { get; set; }

    public long? Tokentype { get; set; }

    public DateTime? Expiry { get; set; }

    public long? Flags { get; set; }
}
