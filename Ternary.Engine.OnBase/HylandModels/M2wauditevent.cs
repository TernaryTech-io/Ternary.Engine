using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class M2wauditevent
{
    public long Mweventnum { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Usernum { get; set; }

    public string? Accessreason { get; set; }

    public string? Ipaddress { get; set; }

    public long? Mwquerynum { get; set; }

    public string? Queryinfo { get; set; }

    public long? Status { get; set; }
}
