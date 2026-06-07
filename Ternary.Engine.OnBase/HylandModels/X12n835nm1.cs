using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835nm1
{
    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public long? Clp835num { get; set; }

    public string? Loopid { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Nm101entitytype { get; set; }

    public string? Nm102entitytypeq { get; set; }

    public string? Nm103lastname { get; set; }

    public string? Nm104firstname { get; set; }

    public string? Nm105middlename { get; set; }

    public string? Nm107suffix { get; set; }

    public string? Nm108idcodeq { get; set; }

    public string? Nm109idcode { get; set; }
}
