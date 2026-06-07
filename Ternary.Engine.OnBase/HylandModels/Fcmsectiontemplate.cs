using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmsectiontemplate
{
    public long Fcsectiontemplnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Fcentitynum { get; set; }

    public string? Fcsectionname { get; set; }

    public long? Active { get; set; }

    public long? Fcoperationalitems { get; set; }

    public long? Flags { get; set; }

    public long? Fccompanynum { get; set; }

    public long? Fcparentnum { get; set; }
}
