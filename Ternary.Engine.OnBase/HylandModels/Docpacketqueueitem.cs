using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docpacketqueueitem
{
    public long? Docpacketjobnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Documentseqnum { get; set; }

    public long? Packetseqnum { get; set; }

    public long? Flags { get; set; }

    public string? Pagerange { get; set; }
}
