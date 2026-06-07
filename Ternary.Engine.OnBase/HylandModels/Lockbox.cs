using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lockbox
{
    public long Lockboxnum { get; set; }

    public string? Lockboxname { get; set; }

    public string? Lockboxid { get; set; }

    public string? Siteid { get; set; }

    public string? Bankid { get; set; }

    public long? Lockboxtype { get; set; }

    public DateTime? Cutofftime { get; set; }

    public long? Processflag { get; set; }

    public long? Reportflags { get; set; }

    public string? Notifyemail { get; set; }

    public string? Lockboxsuffix { get; set; }

    public long? Accountnumkey { get; set; }

    public long? Customernum { get; set; }

    public long? Lockboxitemnum { get; set; }

    public long? Isincomplete { get; set; }

    public long? Exceptionflags { get; set; }

    public long? Usergroupnum { get; set; }

    public long? Retentiondays { get; set; }

    public DateTime? Lastpostdate { get; set; }
}
