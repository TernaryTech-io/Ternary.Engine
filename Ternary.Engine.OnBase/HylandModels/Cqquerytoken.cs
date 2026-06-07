using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cqquerytoken
{
    public long Cqnum { get; set; }

    public long Tokentype { get; set; }

    public long Tokenflags { get; set; }

    public string Idchar1 { get; set; } = null!;

    public string Idchar2 { get; set; } = null!;

    public string Idchar3 { get; set; } = null!;

    public string Idchar4 { get; set; } = null!;

    public string? Keyvaluechar { get; set; }

    public long? Columnwidth { get; set; }
}
