using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmarpatient
{
    public long Rcmarpatientnum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public long? Rcmpatientnum { get; set; }

    public long? Rcmcorecontactinfonum { get; set; }

    public string? Rcmpatlastname { get; set; }

    public string? Rcmpatfirstname { get; set; }

    public string? Rcmpatmi { get; set; }

    public string? Gender { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public string? Rcmmrn { get; set; }

    public string? Rcmssn { get; set; }

    public long? Rcmmaritalstatus { get; set; }

    public string? Creditrating { get; set; }
}
