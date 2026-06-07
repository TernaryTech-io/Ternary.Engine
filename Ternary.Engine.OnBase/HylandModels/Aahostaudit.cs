using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aahostaudit
{
    public long? Masterauditnum { get; set; }

    public long? Aahostnum { get; set; }

    public string? Aahostname { get; set; }

    public string? Domain { get; set; }

    public long? Flags { get; set; }
}
