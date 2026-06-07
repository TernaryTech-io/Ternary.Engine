using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnastudypatient
{
    public long Vnastudynum { get; set; }

    public string? Vnapatientid { get; set; }

    public string? Issuerid { get; set; }

    public string? Vnafirstname { get; set; }

    public string? Vnalastname { get; set; }

    public string? Vnamiddlename { get; set; }

    public string? Vnaptnameprefix { get; set; }

    public string? Vnaptnamesuffix { get; set; }

    public long? Ptsex { get; set; }

    public DateTime? Ptdob { get; set; }

    public long? Assigningauthoritynum { get; set; }

    public long Vnarevnum { get; set; }

    public long? Vnarevstatus { get; set; }

    public long? Vnarevreason { get; set; }

    public DateTime? Createdate { get; set; }
}
