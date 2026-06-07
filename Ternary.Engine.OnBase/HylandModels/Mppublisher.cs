using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mppublisher
{
    public long Mppublishernum { get; set; }

    public long? Usernum { get; set; }

    public long? Transferallowance { get; set; }

    public long? Maxuploadbitrate { get; set; }

    public long? Maxstreams { get; set; }

    public long? Flags { get; set; }

    public string? Mppublisheralias { get; set; }
}
