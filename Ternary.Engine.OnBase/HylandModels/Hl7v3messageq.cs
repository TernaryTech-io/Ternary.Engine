using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3messageq
{
    public long Hl7v3messageqnum { get; set; }

    public long? Hl7v3batchqnum { get; set; }

    public string? Hlv3messageidroot { get; set; }

    public string? Hlv3messageidext { get; set; }

    public string? Hlv3refcontrolid { get; set; }

    public string? Hl7v3interactionext { get; set; }

    public string? Hl7v3interactionroot { get; set; }

    public string? Hl7v3processingcode { get; set; }

    public string? Hl7v3versioncode { get; set; }

    public string? Hl7v3accackcode { get; set; }

    public string? Hl7v3responsemodecode { get; set; }

    public string? Hl7v3processingmodecode { get; set; }

    public long? Hl7v3messagesequence { get; set; }

    public long? Hl7v3lastexecutediapid { get; set; }

    public string? Hl7v3checksum { get; set; }

    public string? Hl7v3adaptertype { get; set; }

    public string? Hl7v3adapterurl { get; set; }

    public long? Hl7v3statuscode { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdappname { get; set; }

    public DateTime? Updateddate { get; set; }

    public string? Updatedappname { get; set; }
}
