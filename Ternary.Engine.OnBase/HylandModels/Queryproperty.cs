using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Queryproperty
{
    public long Querypropertynum { get; set; }

    public string? Displayname { get; set; }

    public string? Qptablename { get; set; }

    public string? Qpcolumnname { get; set; }

    public long? Columnwidth { get; set; }

    public long? Keytypenum { get; set; }

    public long? Flags { get; set; }

    public long? Contexttype { get; set; }
}
