using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmdescription
{
    public long Rmdescriptionid { get; set; }

    public long? Descriptiontype { get; set; }

    public string? Rmdescriptiontext { get; set; }

    public string? Rmlongdescription { get; set; }
}
