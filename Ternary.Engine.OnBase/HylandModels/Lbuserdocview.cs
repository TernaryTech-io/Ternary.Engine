using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbuserdocview
{
    public string Externaluserid { get; set; } = null!;

    public long Docviewnum { get; set; }

    public long? Seqnum { get; set; }
}
