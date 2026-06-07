using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmsubfilterconstraint
{
    public long Subfilterconstraintid { get; set; }

    public long? Connectorflags { get; set; }

    public long? Groupingflags { get; set; }

    public string? Mappeddataaddress { get; set; }

    public long? Rmoperator { get; set; }

    public long? Subfilterid { get; set; }

    public string? Valuedataaddress { get; set; }
}
