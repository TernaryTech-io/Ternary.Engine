using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7receivedmsg
{
    public long Hl7recvmsgnum { get; set; }

    public long? Hl7messagenum { get; set; }

    public DateTime? Receiveddate { get; set; }

    public string? Hl7source { get; set; }

    public string? Hl7messagetype { get; set; }

    public long? Hl7sequence { get; set; }

    public string? Hl7controlid { get; set; }

    public DateTime? Hl7msgdate { get; set; }

    public string? Sendingapp { get; set; }

    public string? Sendingfacility { get; set; }
}
