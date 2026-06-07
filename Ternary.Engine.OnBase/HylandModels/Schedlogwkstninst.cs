using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedlogwkstninst
{
    public long Wkstninstnum { get; set; }

    public long? Registernum { get; set; }

    public long? Usernum { get; set; }

    public string? Instidname { get; set; }

    public long? Logtype { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public DateTime? Scheduleheartbeat { get; set; }

    public DateTime? Schedulelastproctime { get; set; }

    public long? Iterations { get; set; }

    public long? Processid { get; set; }

    public long? Peakseverity { get; set; }
}
