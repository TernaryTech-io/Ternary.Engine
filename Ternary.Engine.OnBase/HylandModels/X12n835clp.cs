using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835clp
{
    public long Clp835num { get; set; }

    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public long? Lx835num { get; set; }

    public string? Loopid { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Clp01patientctlnum { get; set; }

    public string? Clp02statuscode { get; set; }

    public decimal? Clp03totalcharges { get; set; }

    public decimal? Clp04paidamount { get; set; }

    public decimal? Clp05patientresp { get; set; }

    public string? Clp06claimtype { get; set; }

    public string? Clp07payerctlnum { get; set; }

    public string? Clp08facilitycode { get; set; }

    public string? Clp09frequencycode { get; set; }

    public string? Clp11drgcode { get; set; }

    public string? Clp12drgweight { get; set; }

    public string? Clp13percent { get; set; }
}
