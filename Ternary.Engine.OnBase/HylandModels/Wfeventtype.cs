using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfeventtype
{
    public long Wfeventtypenum { get; set; }

    public long? Wfeventsourcenum { get; set; }

    public long? Wfcontenttype { get; set; }

    public string? Wfeventtypename { get; set; }

    public long? Tasklistnum { get; set; }

    public long? Flags { get; set; }
}
