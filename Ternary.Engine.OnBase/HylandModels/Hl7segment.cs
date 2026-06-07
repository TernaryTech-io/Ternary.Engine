using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7segment
{
    public long Hl7segmentnum { get; set; }

    public string? Hl7segmentname { get; set; }

    public string? Hl7segmentid { get; set; }

    public long? Flags { get; set; }

    public long? Hl7setid { get; set; }
}
