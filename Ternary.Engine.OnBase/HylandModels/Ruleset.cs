using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ruleset
{
    public long Rulesetnum { get; set; }

    public string? Rulesetname { get; set; }

    public string? Rulesetxml { get; set; }

    public DateTime? Lastupdate { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }

    public long? Rsversionnum { get; set; }
}
