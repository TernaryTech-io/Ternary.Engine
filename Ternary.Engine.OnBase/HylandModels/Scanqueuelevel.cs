using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scanqueuelevel
{
    public long? Scanqueuenum { get; set; }

    public long? Batchstatus { get; set; }

    public long? Highwatermark { get; set; }

    public string? Emailaddress { get; set; }

    public DateTime? Lastupdate { get; set; }
}
