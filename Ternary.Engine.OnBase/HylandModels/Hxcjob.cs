using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hxcjob
{
    public long Hxcjobnum { get; set; }

    public long? Hxcprocessnum { get; set; }

    public string? Packagepath { get; set; }

    public DateTime? Submitdatetime { get; set; }

    public long? Jobflags { get; set; }

    public long? Priority { get; set; }

    public long? Status { get; set; }
}
