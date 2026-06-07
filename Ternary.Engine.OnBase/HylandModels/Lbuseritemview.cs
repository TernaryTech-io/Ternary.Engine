using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbuseritemview
{
    public string Externaluserid { get; set; } = null!;

    public long Itemviewnum { get; set; }

    public long? Flags { get; set; }
}
