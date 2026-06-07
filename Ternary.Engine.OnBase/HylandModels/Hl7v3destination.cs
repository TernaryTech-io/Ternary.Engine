using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3destination
{
    public long Hl7v3destnum { get; set; }

    public string? Hl7v3customname { get; set; }

    public string? Hl7v3description { get; set; }

    public string? Hl7v3adapterurl { get; set; }

    public string? Hl7v3adaptertype { get; set; }

    public long? Flags { get; set; }

    public long? Hl7v3actionpronum { get; set; }

    public string? Hl7logfile { get; set; }

    public string? Receiverdeviceid { get; set; }

    public string? Receiverreporgid { get; set; }

    public string? Recieverlocationid { get; set; }

    public string? Hl7v3receivername { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Lastmodifieduser { get; set; }
}
