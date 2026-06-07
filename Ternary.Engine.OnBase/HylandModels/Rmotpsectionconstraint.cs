using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmotpsectionconstraint
{
    public long Sectionconstraintid { get; set; }

    public long? Connectorflags { get; set; }

    public string? Dataaddress { get; set; }

    public long? Groupingflags { get; set; }

    public long? Matchtype { get; set; }

    public long? Rmoperator { get; set; }

    public long? Sectionid { get; set; }
}
