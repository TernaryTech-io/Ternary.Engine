using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7recvmsgdatum
{
    public long? Hl7recvmsgnum { get; set; }

    public long? Seqnum { get; set; }

    public string? Hl7segmentid { get; set; }

    public string? Hl7valuereference { get; set; }

    public long? Repeatnum { get; set; }

    public string? Matchname { get; set; }

    public string? Matchvalue { get; set; }
}
