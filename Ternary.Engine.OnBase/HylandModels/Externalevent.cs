using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Externalevent
{
    public long Externaleventnum { get; set; }

    public long? Usernum { get; set; }

    public long? Itemnum { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Eventsource { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Revisionnum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Flags { get; set; }

    public long? Extrainfo1 { get; set; }
}
