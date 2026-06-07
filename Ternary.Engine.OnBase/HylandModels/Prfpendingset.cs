using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Prfpendingset
{
    public long Prfpendingsetnum { get; set; }

    public string? Patientname { get; set; }

    public string? Prfmedrecnumber { get; set; }

    public DateTime? Ptdob { get; set; }

    public long? Lcid { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Dptnum { get; set; }

    public long? Status { get; set; }

    public long? Createdby { get; set; }

    public string? Patientencounter { get; set; }

    public string? Patientorder { get; set; }

    public long? Flags { get; set; }

    public long? Patientchtnum { get; set; }
}
