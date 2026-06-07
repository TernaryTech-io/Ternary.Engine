using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3outboundq
{
    public long Hl7v3outboundqnum { get; set; }

    public long? Hl7v3batchqnum { get; set; }

    public long? Hl7v3triggerqnum { get; set; }

    public string? Hl7v3messageid { get; set; }

    public long? Hl7v3statuscode { get; set; }

    public long? Hl7v3destnum { get; set; }

    public long? Retrycount { get; set; }

    public string? Hl7v3checksum { get; set; }

    public string? Createdappname { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Updatedappname { get; set; }

    public DateTime? Updateddate { get; set; }
}
