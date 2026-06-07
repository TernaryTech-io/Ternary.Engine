using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amminutehistory
{
    public long Amminutehistnum { get; set; }

    public long? Ammeetingnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Ameventtime { get; set; }

    public string? Ameventtype { get; set; }

    public string? Ameventdetail { get; set; }

    public string? Amipaddress { get; set; }
}
