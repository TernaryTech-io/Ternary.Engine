using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fhirdocreference
{
    public long Fhirdocrefnum { get; set; }

    public string? Fhirresourceid { get; set; }

    public long? Fhirdocrefstatus { get; set; }

    public DateTime? Fhirindexeddate { get; set; }

    public long? Fhirversionid { get; set; }

    public DateTime? Fhirlastupdated { get; set; }

    public long? Flags { get; set; }
}
