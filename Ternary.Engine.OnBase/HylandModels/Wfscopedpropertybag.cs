using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfscopedpropertybag
{
    public long? Sessionid { get; set; }

    public string? Propertybagguid { get; set; }

    public string? Propertyname { get; set; }

    public string? Wfpropertyvalue { get; set; }

    public long? Wfpropertyvaluelen { get; set; }

    public long? Propertytype { get; set; }

    public long? Elementloc { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }

    public long? Maxseqnum { get; set; }

    public DateTime? Proptimestamp { get; set; }

    public string? Propertynameuc { get; set; }
}
