using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7segmentfield
{
    public long Hl7fieldnum { get; set; }

    public long? Hl7segmentnum { get; set; }

    public long? Seqnum { get; set; }

    public string? Hl7fieldid { get; set; }

    public string? Hl7fieldname { get; set; }

    public long? Keytypenum { get; set; }

    public string? Defaultfieldvalue { get; set; }

    public long? Flags { get; set; }

    public long? Chartfieldnum { get; set; }

    public long? Hl7tablenum { get; set; }

    public long? Hl7codedentrynum { get; set; }
}
