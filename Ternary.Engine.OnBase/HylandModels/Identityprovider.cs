using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Identityprovider
{
    public long Idpnum { get; set; }

    public long? Idptype { get; set; }

    public long? Obblobnum { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }
}
