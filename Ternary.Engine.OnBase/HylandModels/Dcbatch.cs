using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcbatch
{
    public long Dcbatchnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Objectid { get; set; }

    public string? Xmldata { get; set; }

    public long? Dctemplatenum { get; set; }

    public long? Itemtypenum { get; set; }

    public DateTime? Requesttime { get; set; }

    public long? Flags { get; set; }

    public long? Ownerid { get; set; }

    public long? Status { get; set; }

    public long? Dcerrcount { get; set; }

    public string? Dcerrmessage { get; set; }

    public long? Itemrevisionnum { get; set; }

    public long? Lcnum { get; set; }
}
