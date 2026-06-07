using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Batchdoclog
{
    public long Batchdoclognum { get; set; }

    public long? Itemnum { get; set; }

    public long? Pagecount { get; set; }

    public long? Transitionlognum { get; set; }

    public long? Sourcesetnum { get; set; }
}
