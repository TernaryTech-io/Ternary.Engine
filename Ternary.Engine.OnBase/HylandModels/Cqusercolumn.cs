using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cqusercolumn
{
    public long Cqnum { get; set; }

    public long Usernum { get; set; }

    public long Seqnum { get; set; }

    public long? Columnwidth { get; set; }

    public long? Groupseqnum { get; set; }
}
