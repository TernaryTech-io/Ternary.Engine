using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835moa
{
    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public long? Clp835num { get; set; }

    public string? Loopid { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Moa01reimburserate { get; set; }

    public string? Moa02hcpcspayableamt { get; set; }

    public string? Moa03remarkcode { get; set; }

    public string? Moa04remarkcode { get; set; }

    public string? Moa05remarkcode { get; set; }

    public string? Moa06remarkcode { get; set; }

    public string? Moa07remarkcode { get; set; }

    public decimal? Moa08esrdpayamt { get; set; }

    public decimal? Moa09nonpayprofamt { get; set; }

    public decimal? Moa02hcpcspayableamtr { get; set; }
}
