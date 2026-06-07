using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmviewitemdocument
{
    public long Viewitemdocid { get; set; }

    public long? Attachfromsource { get; set; }

    public string? Dataaddress { get; set; }

    public long? Viewitemid { get; set; }

    public long? Viewtype { get; set; }

    public long? Flags { get; set; }
}
