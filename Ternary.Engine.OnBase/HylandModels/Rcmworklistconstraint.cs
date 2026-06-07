using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmworklistconstraint
{
    public long? Rcmworklistnum { get; set; }

    public long? Rcmconstraintdatatype { get; set; }

    public long? Logicoperator { get; set; }

    public long? Binaryoperator { get; set; }

    public string? Value { get; set; }

    public string? Constraintid { get; set; }

    public long? Rcmwlreasonnum { get; set; }
}
