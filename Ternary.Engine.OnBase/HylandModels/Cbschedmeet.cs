using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cbschedmeet
{
    public long Schedmeetnum { get; set; }

    public string? Hostschedmeetnum { get; set; }

    public long? Organizernum { get; set; }

    public string? Meetsubject { get; set; }

    public long? Meettype { get; set; }

    public DateTime? Meettime { get; set; }

    public long? Dayofweek { get; set; }

    public DateTime? Timeofday { get; set; }

    public long? Workspacenum { get; set; }

    public long? Meetflags { get; set; }

    public string? Meetpassword { get; set; }

    public string? Joinurl { get; set; }

    public string? Conferencecall { get; set; }

    public long? Maxparticipants { get; set; }

    public long? Duration { get; set; }

    public long? Active { get; set; }
}
