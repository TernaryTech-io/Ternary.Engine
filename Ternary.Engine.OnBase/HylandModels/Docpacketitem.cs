using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docpacketitem
{
    public long? Itemnum { get; set; }

    public long? Packetitemnum { get; set; }

    public long? Itrevnum { get; set; }

    public string? Pagerange { get; set; }

    public long? Seqnum { get; set; }

    public long? Numrepeats { get; set; }

    public long? Flags { get; set; }

    public long? Docrevnum { get; set; }

    public long? Filetypenum { get; set; }
}
