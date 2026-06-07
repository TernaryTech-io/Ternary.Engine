using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Caseinstance
{
    public long Caseinstancenum { get; set; }

    public long? Casedefnum { get; set; }

    public string? Hashcode { get; set; }

    public string? Searchterms { get; set; }
}
