using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Deploymentfile
{
    public long? Deploymentid { get; set; }

    public long? Versionnum { get; set; }

    public long? Itemnum { get; set; }

    public string? Asmversion { get; set; }
}
