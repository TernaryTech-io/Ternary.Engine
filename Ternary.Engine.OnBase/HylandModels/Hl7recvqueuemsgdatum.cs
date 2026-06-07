using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7recvqueuemsgdatum
{
    public long? Hl7recvqueuenum { get; set; }

    public long? Seqnum { get; set; }

    public string? Hl7data { get; set; }
}
