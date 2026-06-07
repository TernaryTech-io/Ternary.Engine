using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docpacketqueue
{
    public long Docpacketjobnum { get; set; }

    public long? Usernum { get; set; }

    public long? Docpackettmplnum { get; set; }

    public long? Primaryitemnum { get; set; }

    public long? Archiveitemtypenum { get; set; }

    public DateTime? Documentdate { get; set; }

    public long? Status { get; set; }

    public long? Packetitemnum { get; set; }

    public long? Flags { get; set; }
}
