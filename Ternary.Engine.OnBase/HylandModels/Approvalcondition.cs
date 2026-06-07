using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Approvalcondition
{
    public long Approvalcondnum { get; set; }

    public long? Approvalrulenum { get; set; }

    public long? Approvalcondtype { get; set; }

    public long? Parentapprovalcondnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
