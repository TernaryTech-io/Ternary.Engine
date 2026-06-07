using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmsplitruleset
{
    public long Splitrulesetnum { get; set; }

    public string? Splitrulesetname { get; set; }

    public long? Rcmsplitnum { get; set; }

    public string? Outputdirectory { get; set; }

    public string? Outputfilemask { get; set; }

    public long? Rulesetpriority { get; set; }

    public long? Maxclaimcount { get; set; }

    public long? Splitoncheck { get; set; }
}
