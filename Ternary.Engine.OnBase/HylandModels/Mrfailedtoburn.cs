using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrfailedtoburn
{
    public long Failedburnnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Dfcynum { get; set; }

    public long? Notenum { get; set; }

    public long? Facilitynum { get; set; }

    public long? Usernum { get; set; }

    public long? Failurereason { get; set; }

    public DateTime? Failuredate { get; set; }

    public long? Failurecount { get; set; }

    public long? Flags { get; set; }
}
