using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ufuseraction
{
    public long Ufuseractionnum { get; set; }

    public long? Ufcustomactionnum { get; set; }

    public long? Ufactiontype { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
