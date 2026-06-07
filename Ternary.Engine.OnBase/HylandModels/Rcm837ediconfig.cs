using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcm837ediconfig
{
    public long Rcm837edicfgnum { get; set; }

    public long? Parsefilenum { get; set; }

    public long? Rcmsefconfignum { get; set; }

    public long? Rcmhostsystemnum { get; set; }
}
