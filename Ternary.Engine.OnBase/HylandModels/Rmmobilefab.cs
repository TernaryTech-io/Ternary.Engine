using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmmobilefab
{
    public long Mobilefabid { get; set; }

    public long? Mobilecomponentid { get; set; }

    public long? Rmoperationid { get; set; }

    public long? Flags { get; set; }

    public string? Fabtitle { get; set; }

    public long? Rmdescriptionid { get; set; }

    public long? Seqnum { get; set; }
}
