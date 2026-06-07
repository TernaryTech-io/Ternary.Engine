using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lctransition
{
    public long Transitnum { get; set; }

    public long? Statenumfrom { get; set; }

    public long? Statenumto { get; set; }

    public long? Lcnum { get; set; }

    public long? Eventnum { get; set; }

    public long? Defaulttransition { get; set; }

    public long? Preactionlistnum { get; set; }

    public long? Rulelistnum { get; set; }

    public long? Postactionlistnum { get; set; }

    public long? Flags { get; set; }
}
