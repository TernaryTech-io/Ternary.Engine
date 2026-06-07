using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wftransactionmsg
{
    public long Wftransactionnum { get; set; }

    public long Flags { get; set; }

    public string? Wfmessage { get; set; }
}
