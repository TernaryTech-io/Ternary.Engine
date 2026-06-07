using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Extauthproperty
{
    public long? Extauthpropgrpnum { get; set; }

    public string? Propname { get; set; }

    public string? Propvalue { get; set; }

    public long? Propflags { get; set; }

    public string? Propdescription { get; set; }

    public string? Propvalueformat { get; set; }

    public long Exauthpropnum { get; set; }

    public long? Parentpropnum { get; set; }

    public long? Externalauthnum { get; set; }

    public long? Seqnum { get; set; }
}
