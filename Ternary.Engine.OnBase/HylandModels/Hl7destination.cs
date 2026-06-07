using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7destination
{
    public long Hl7destnum { get; set; }

    public string? Hl7destname { get; set; }

    public string? Hl7destdesc { get; set; }

    public long? Hl7destport { get; set; }

    public long? Flags { get; set; }

    public string? Hl7logfile { get; set; }

    public long? Disconminutes { get; set; }

    public long? Adminusernum { get; set; }

    public long? Retryminutes { get; set; }

    public long? Itemtypenum { get; set; }
}
