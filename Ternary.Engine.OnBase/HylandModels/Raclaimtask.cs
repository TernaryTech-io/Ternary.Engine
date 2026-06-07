using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raclaimtask
{
    public long Racclaimtasknum { get; set; }

    public long? Raoutcomecodenum { get; set; }

    public long? Racclaimnum { get; set; }

    public long? Taskcreatedbyusernum { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Taskassignedtousernum { get; set; }

    public string? Taskdesc { get; set; }

    public string? Taskdetails { get; set; }

    public string? Taskoutcome { get; set; }

    public long? Taskstatus { get; set; }

    public DateTime? Expecttaskcompleteddate { get; set; }

    public DateTime? Taskcompleteddate { get; set; }

    public long? Createdeformitemnum { get; set; }

    public long? Ratasktypenum { get; set; }

    public long? Claimlevel { get; set; }

    public long? Seqnum { get; set; }
}
