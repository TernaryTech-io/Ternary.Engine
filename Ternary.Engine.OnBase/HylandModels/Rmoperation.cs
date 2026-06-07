using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmoperation
{
    public long Rmoperationid { get; set; }

    public long? Operationtype { get; set; }

    public long? Operationproperty { get; set; }

    public string? Value { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }

    public long? Parentid { get; set; }

    public long? Rmdescriptionid { get; set; }

    public long? Testoperator { get; set; }

    public string? Testdataaddress { get; set; }

    public long? Rmobjectkey { get; set; }

    public long? Rmobjecttype { get; set; }
}
