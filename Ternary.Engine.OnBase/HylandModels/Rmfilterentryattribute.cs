using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmfilterentryattribute
{
    public long Filterentryid { get; set; }

    public long? Allowduplicates { get; set; }

    public long? Connectorflags { get; set; }

    public string? Dataaddress { get; set; }

    public string? Defaultvalue { get; set; }

    public long? Displaydataset { get; set; }

    public long? Filterid { get; set; }

    public long? Groupingflags { get; set; }

    public long? Rmoperator { get; set; }

    public string? Promptstring { get; set; }

    public long? Required { get; set; }

    public long? Sequenceid { get; set; }
}
