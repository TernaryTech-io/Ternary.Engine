using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lineitemmargin
{
    public long Queuenum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Headersize { get; set; }

    public long? Footersize { get; set; }
}
