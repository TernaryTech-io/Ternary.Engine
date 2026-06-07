using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmadditionalreviewer
{
    public long Fcaddreviewernum { get; set; }

    public long? Etitemid { get; set; }

    public long? Entitytypenum { get; set; }

    public long? Seqnum { get; set; }

    public long? Reviewerusernum { get; set; }

    public long? Reviewstatus { get; set; }

    public long? Flags { get; set; }

    public DateTime? Readydate { get; set; }

    public DateTime? Reviewdate { get; set; }
}
