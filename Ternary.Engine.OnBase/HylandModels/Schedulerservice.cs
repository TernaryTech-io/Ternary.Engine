using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedulerservice
{
    public long Schedservicenum { get; set; }

    public string? Schedservicename { get; set; }

    public string? Servername { get; set; }

    public string? Domain { get; set; }

    public long? Workerpoolnum { get; set; }

    public string? Odbcname { get; set; }

    public long? Institution { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Lastheartbeat { get; set; }

    public long? Flags { get; set; }
}
