using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartaccessreq
{
    public long Chtrequestnum { get; set; }

    public long? Requsernum { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Mpinum { get; set; }

    public long? Mrnum { get; set; }

    public long? Chtnum { get; set; }

    public long? Emergencyaccess { get; set; }

    public long? Flags { get; set; }

    public string? Requestaccnote { get; set; }

    public string? Requestreason { get; set; }

    public long? Chtaccreasonnum { get; set; }

    public long? Deletestatus { get; set; }

    public long? Requestdays { get; set; }
}
