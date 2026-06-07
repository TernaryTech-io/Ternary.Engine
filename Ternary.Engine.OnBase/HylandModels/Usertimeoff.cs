using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Usertimeoff
{
    public long? Usernum { get; set; }

    public string? Timeoffname { get; set; }

    public DateTime? Startdate { get; set; }

    public long? Wstarttime { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Wendtime { get; set; }

    public long? Flags { get; set; }
}
