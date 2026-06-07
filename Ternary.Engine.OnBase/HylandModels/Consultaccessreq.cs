using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Consultaccessreq
{
    public long Chtrequestnum { get; set; }

    public string? Requestreason { get; set; }

    public long? Reqphysnum { get; set; }

    public long? Numdaysreq { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Consultphysnum { get; set; }

    public long? Requesturgency { get; set; }

    public long? Requeststatus { get; set; }

    public long? Mpinum { get; set; }

    public long? Mrnum { get; set; }

    public long? Chtnum { get; set; }

    public long? Chtorrec { get; set; }

    public long? Deletestatus { get; set; }
}
