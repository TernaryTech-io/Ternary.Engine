using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3batchq
{
    public long Hl7v3batchqnum { get; set; }

    public string? Hl7v3batchidroot { get; set; }

    public string? Hl7v3batchidext { get; set; }

    public long? Hl7v3envelopeid { get; set; }

    public long? Hl7v3transmissionqty { get; set; }

    public string? Hl7v3refcontrolid { get; set; }

    public string? Hl7v3interactionidext { get; set; }

    public string? Hl7v3interactionidroot { get; set; }

    public string? Hl7v3versioncode { get; set; }

    public string? Hl7v3responsemodecode { get; set; }

    public string? Hl7v3accackcode { get; set; }

    public string? Hl7v3securitytext { get; set; }

    public string? Hl7v3name { get; set; }

    public long? Hl7v3isbatch { get; set; }

    public string? Hl7v3checksum { get; set; }

    public string? Hl7v3adaptertype { get; set; }

    public long? Hl7v3statuscode { get; set; }

    public long? Hl7v3zoneocrform { get; set; }

    public string? Hl7v3adapterurl { get; set; }

    public string? Hl7v3machinename { get; set; }

    public DateTime? Createddate { get; set; }

    public DateTime? Updateddate { get; set; }

    public string? Updatedappname { get; set; }

    public string? Createdappname { get; set; }
}
