using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Classifycrawler
{
    public long Clcrawlernum { get; set; }

    public long? Itemnum { get; set; }

    public string? Fullfilepath { get; set; }

    public long? Status { get; set; }

    public long? Cldoctypenum { get; set; }

    public long? Clsystemnum { get; set; }

    public long? Toolstriedflags { get; set; }

    public long? Timescheduled { get; set; }

    public long? Pagenumber { get; set; }

    public long? Trainingsetnumber { get; set; }
}
