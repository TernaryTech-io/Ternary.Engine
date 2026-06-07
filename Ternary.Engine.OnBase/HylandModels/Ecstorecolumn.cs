using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecstorecolumn
{
    public long Ecstorenum { get; set; }

    public long? Refcoltype { get; set; }

    public long? Refcolflags { get; set; }

    public long? Keytypenum { get; set; }

    public string? Reftablename { get; set; }

    public string? Refcolumnname { get; set; }

    public string? Ecdisplayname { get; set; }

    public long? Ecdisplaywidth { get; set; }

    public long Seqnum { get; set; }
}
