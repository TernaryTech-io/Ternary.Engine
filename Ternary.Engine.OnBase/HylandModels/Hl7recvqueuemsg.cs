using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7recvqueuemsg
{
    public long Hl7recvqueuenum { get; set; }

    public long? Hl7processnum { get; set; }

    public long? Hl7messagenum { get; set; }

    public long? Processtype { get; set; }

    public DateTime? Receiveddate { get; set; }

    public string? Hl7messagetype { get; set; }

    public long? Hl7sequence { get; set; }

    public string? Hl7controlid { get; set; }

    public long? Flags { get; set; }

    public long? Actiontype { get; set; }
}
