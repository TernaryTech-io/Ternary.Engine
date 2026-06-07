using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Businessholiday
{
    public long? Wcalnum { get; set; }

    public string? Holidayname { get; set; }

    public DateTime? Startdate { get; set; }

    public long? Wstarttime { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Wendtime { get; set; }

    public long? Flags { get; set; }
}
