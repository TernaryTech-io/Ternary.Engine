using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmcomponent
{
    public long Rmcomponentid { get; set; }

    public string? Rmname { get; set; }

    public long? Rmcomponenttype { get; set; }

    public long? Parentid { get; set; }

    public long? Primarycomponentid { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }

    public long? Activestatus { get; set; }
}
