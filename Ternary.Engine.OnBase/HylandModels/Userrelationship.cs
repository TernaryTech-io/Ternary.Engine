using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Userrelationship
{
    public long? Usernum { get; set; }

    public long? Relateduser { get; set; }

    public long? Orgchartnum { get; set; }

    public long? Relationshiptype { get; set; }

    public long? Flags { get; set; }
}
