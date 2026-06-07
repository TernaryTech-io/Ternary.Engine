using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Approvalprocess
{
    public long Approvalprocnum { get; set; }

    public string? Approvalprocname { get; set; }

    public string? Approvalprocdesc { get; set; }

    public long? Versionid { get; set; }

    public long? Wfcontenttype { get; set; }

    public DateTime? Lastupdated { get; set; }

    public long? Lastupdatedby { get; set; }

    public long? Delegationconfnum { get; set; }

    public long? Escalationconfnum { get; set; }

    public long? Flags { get; set; }

    public long? Configversion { get; set; }
}
