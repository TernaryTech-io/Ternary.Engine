using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emailauditlog
{
    public long Emailauditnum { get; set; }

    public string? Emailaction { get; set; }

    public DateTime? Eventdate { get; set; }

    public string? Eventmessage { get; set; }

    public long? Usernum { get; set; }

    public long? Emailnum { get; set; }

    public long? Emailarchivenum { get; set; }
}
