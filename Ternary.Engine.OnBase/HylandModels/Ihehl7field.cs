using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ihehl7field
{
    public long Ihehl7fieldnum { get; set; }

    public long? Hl7fldtemplatenum { get; set; }

    public long? Hl7fieldgroupid { get; set; }

    public string? Hl7fieldid { get; set; }

    public string? Hl7fieldname { get; set; }

    public long? Hl7tablenum { get; set; }

    public string? Ihestaticvalue { get; set; }

    public long? Ihecardinality { get; set; }

    public long? Keytypenum { get; set; }

    public long? Flags { get; set; }
}
