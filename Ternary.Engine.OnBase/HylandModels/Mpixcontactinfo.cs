using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpixcontactinfo
{
    public long? Mpinum { get; set; }

    public long? Status { get; set; }

    public long? Ptcontacttype { get; set; }

    public string? Ptcontacttext { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Stopdate { get; set; }

    public long Mpicontactinfonum { get; set; }
}
