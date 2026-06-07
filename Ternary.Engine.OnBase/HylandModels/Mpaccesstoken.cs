using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpaccesstoken
{
    public string? Mpaccesstokenname { get; set; }

    public long? Mpmedianum { get; set; }

    public long? Mppublishernum { get; set; }

    public DateTime? Expirationtime { get; set; }

    public long? Usernum { get; set; }
}
