using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfdeleted
{
    public long Wfitemid { get; set; }

    public string? Wfitemname { get; set; }

    public long? Wfitemtype { get; set; }

    public long? Scope { get; set; }

    public DateTime? Deleteddate { get; set; }

    public long Usernum { get; set; }

    public long? Flags { get; set; }
}
