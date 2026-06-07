using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmconstraint
{
    public long Rmconstraintid { get; set; }

    public long? Constraintsetid { get; set; }

    public long? Sequenceid { get; set; }

    public string? Dataaddress { get; set; }

    public long? Rmoperator { get; set; }

    public string? Attributevalue { get; set; }

    public long? Connectorflags { get; set; }

    public long? Groupingflags { get; set; }

    public long? Flags { get; set; }
}
