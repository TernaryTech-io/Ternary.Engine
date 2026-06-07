using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vrwarn
{
    public long Verrepnum { get; set; }

    public long? Errorcode { get; set; }

    public string? Errorstr { get; set; }

    public long? Filenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Keytypenum { get; set; }

    public long? Seqnum { get; set; }

    public long? Sequencenum { get; set; }
}
