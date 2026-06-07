using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medpopcolconfig
{
    public long Uicontext { get; set; }

    public long Fieldnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }

    public long? Medpopcolenabled { get; set; }

    public long? Defsortseqnum { get; set; }

    public long? Defsortdirection { get; set; }

    public long Iskeyword { get; set; }
}
