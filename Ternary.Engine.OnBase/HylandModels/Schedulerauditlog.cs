using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedulerauditlog
{
    public long Schedeventnum { get; set; }

    public long? Eventtype { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Usernum { get; set; }

    public long? Schedtasknum { get; set; }

    public string? Schedtaskname { get; set; }

    public long? Schedulenum { get; set; }

    public string? Schedulename { get; set; }

    public long? Execwindtemplnum { get; set; }

    public string? Execwindtemplname { get; set; }

    public long? Workerpoolnum { get; set; }

    public long? Schedjobnum { get; set; }

    public string? Schedeventmessage { get; set; }

    public long? Param1 { get; set; }

    public long? Param2 { get; set; }

    public long? Param3 { get; set; }

    public long? Flags { get; set; }
}
