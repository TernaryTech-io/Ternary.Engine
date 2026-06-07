using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obacomponent
{
    public long Obacompnum { get; set; }

    public string? Obacompguid { get; set; }

    public string? Obaname { get; set; }

    public string? Obacomptype { get; set; }

    public long? Parentnum { get; set; }

    public long? Primarycompnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
