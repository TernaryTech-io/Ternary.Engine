using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrdocumentattachjob
{
    public long Mrdocattachjobnum { get; set; }

    public long? Schedtasknum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Jobtype { get; set; }

    public long? Status { get; set; }

    public long? Processedcount { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public long? Elapsedtime { get; set; }

    public long? Flags { get; set; }

    public DateTime? Forcedate { get; set; }

    public DateTime? Todate { get; set; }

    public DateTime? Fromdate { get; set; }
}
