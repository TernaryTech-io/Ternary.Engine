using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Pswdrule
{
    public long Pswdrulenum { get; set; }

    public long? Ruletype { get; set; }

    public long? Flags { get; set; }

    public long? Pswdcount { get; set; }

    public long? Pswdpolicynum { get; set; }
}
