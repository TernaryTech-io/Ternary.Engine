using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docpacketitemset
{
    public long Packetitemsetnum { get; set; }

    public string? Packetitemsetname { get; set; }

    public long? Docpackettmplnum { get; set; }

    public long? Packetitemsettype { get; set; }

    public long? Packetitemsettypeid { get; set; }

    public long? Seqnum { get; set; }

    public long? Numcopies { get; set; }

    public long? Flags { get; set; }

    public long? Daterangekeytypenum { get; set; }

    public long? Sortkeytypenum { get; set; }

    public long? Papersize { get; set; }
}
