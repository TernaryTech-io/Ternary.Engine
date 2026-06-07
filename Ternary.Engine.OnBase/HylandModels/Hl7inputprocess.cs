using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7inputprocess
{
    public long Hl7processnum { get; set; }

    public string? Hl7processname { get; set; }

    public long? Hl7messagenum { get; set; }

    public long? Processtype { get; set; }

    public long? Keynum { get; set; }

    public string? Dumppath { get; set; }

    public long? Flags { get; set; }

    public string? Sendingapp { get; set; }

    public string? Sendingfacility { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Extrainfo2 { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags2 { get; set; }

    public string? Segmentfilter { get; set; }

    public long? Mrcontrolsys { get; set; }

    public string? Description { get; set; }

    public long? Hl7inputgroupnum { get; set; }
}
