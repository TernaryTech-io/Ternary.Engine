using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workholiday
{
    public long? Wcalnum { get; set; }

    public DateTime? Holidaydate { get; set; }

    public long? Workdaystart { get; set; }

    public long? Workdayend { get; set; }

    public long? Flags { get; set; }
}
