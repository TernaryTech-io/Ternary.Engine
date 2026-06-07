using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doubletakeserver
{
    public long Dtservernum { get; set; }

    public string? Dtservermachinename { get; set; }

    public long? Dtserverport { get; set; }

    public string? Dtserveraccountname { get; set; }

    public string? Dtserverpassword { get; set; }

    public string? Dtserveraccountdomain { get; set; }

    public long? Flags { get; set; }

    public string? Licensecode { get; set; }

    public string? Passwordiv { get; set; }
}
