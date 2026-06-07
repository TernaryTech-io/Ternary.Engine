using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ammeetingtext
{
    public long Ammeetingtextnum { get; set; }

    public long? Ammeetingnum { get; set; }

    public long? Texttypenum { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }

    public string? Meetingtext { get; set; }
}
