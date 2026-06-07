using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3triggerq
{
    public long Hl7v3triggerqnum { get; set; }

    public long? Hl7v3templatenum { get; set; }

    public long? Hl7v3destnum { get; set; }

    public long? Hl7v3statuscode { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Hl7v3lastexecutediapid { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdappname { get; set; }

    public DateTime? Updateddate { get; set; }

    public string? Updatedappname { get; set; }
}
