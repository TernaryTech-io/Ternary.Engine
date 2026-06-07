using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docpacket
{
    public long? Packetitemnum { get; set; }

    public long? Primaryitemnum { get; set; }

    public long? Docpackettmplnum { get; set; }

    public DateTime? Timestamp { get; set; }

    public long? Flags { get; set; }
}
