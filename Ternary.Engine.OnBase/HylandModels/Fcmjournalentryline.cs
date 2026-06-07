using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmjournalentryline
{
    public long Fcjelinenum { get; set; }

    public string? Fcaccountcode { get; set; }

    public string? Fcdescription { get; set; }

    public decimal? Fcdebitamount { get; set; }

    public long? Fcjournalentrynum { get; set; }

    public long? Seqnum { get; set; }

    public decimal? Fccreditamount { get; set; }

    public long? Flags { get; set; }

    public long? Fcaccountnum { get; set; }
}
