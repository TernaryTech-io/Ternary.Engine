using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedexecutionwindow
{
    public long Execwindtemplnum { get; set; }

    public long? Daysofweek { get; set; }

    public DateTime? Schedexecutionstart { get; set; }

    public DateTime? Schedexecutionend { get; set; }

    public long? Flags { get; set; }
}
