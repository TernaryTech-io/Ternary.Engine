using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmpatient
{
    public long Rcmpatientnum { get; set; }

    public string? Rcmpatfirstname { get; set; }

    public string? Rcmpatlastname { get; set; }

    public string? Rcmpatmi { get; set; }

    public string? Gender { get; set; }

    public long? Rcmcontactinfonum { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public string? Rcmssn { get; set; }

    public string? Rcmmrn { get; set; }

    public long? Maritalstatus { get; set; }

    public string? Creditrating { get; set; }

    public string? Dependentstatus { get; set; }

    public long? Origin { get; set; }

    public long? Mrnum { get; set; }

    public long? Originalbatchnum { get; set; }

    public long? Lastbatchnum { get; set; }
}
