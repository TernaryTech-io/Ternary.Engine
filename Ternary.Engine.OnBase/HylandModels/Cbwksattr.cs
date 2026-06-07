using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cbwksattr
{
    public long Attributenum { get; set; }

    public long? Wkstemplatenum { get; set; }

    public string? Attributename { get; set; }

    public long? Attrdatatype { get; set; }

    public long? Datalength { get; set; }

    public long? Seqnum { get; set; }
}
