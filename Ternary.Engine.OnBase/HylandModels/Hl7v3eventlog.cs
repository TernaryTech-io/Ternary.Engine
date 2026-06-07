using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3eventlog
{
    public long Hl7v3eventlognum { get; set; }

    public long? Hl7v3objectid { get; set; }

    public string? Hl7v3objecttype { get; set; }

    public string? Hl7v3logactiontype { get; set; }

    public string? Hl7v3description { get; set; }

    public long? Hl7v3errorcode { get; set; }

    public string? Hl7v3errortext { get; set; }

    public string? Hl7v3applicationname { get; set; }

    public string? Hl7v3machinename { get; set; }

    public string? Hl7v3senderclass { get; set; }

    public string? Hl7v3functionname { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Hl7v3loggedby { get; set; }
}
