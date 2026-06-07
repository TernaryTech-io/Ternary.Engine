using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cbwksitem
{
    public long Workspacenum { get; set; }

    public long Typeofitem { get; set; }

    public long Threadid { get; set; }

    public long Itemnum { get; set; }

    public long Objectid { get; set; }

    public DateTime? Dateadded { get; set; }

    public long? Useradded { get; set; }

    public long Schedmeetnum { get; set; }

    public long? Securityflags { get; set; }

    public long? Flags { get; set; }

    public long Cbfoldernum { get; set; }

    public long? Incbfoldernum { get; set; }
}
