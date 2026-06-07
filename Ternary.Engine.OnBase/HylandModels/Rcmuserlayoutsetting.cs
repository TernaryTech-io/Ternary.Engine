using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmuserlayoutsetting
{
    public long Rcmuserlosetnum { get; set; }

    public long? Obblobnum { get; set; }

    public long? Usernum { get; set; }

    public string? Contextname { get; set; }

    public string? Rcmlayoutname { get; set; }

    public long? Flags { get; set; }

    public long? Rcmlayoutnum { get; set; }

    public long? Rcmworklistnum { get; set; }

    public DateTime? Lastmodified { get; set; }
}
