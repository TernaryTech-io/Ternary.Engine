using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gisglobalconfig
{
    public long Gisglobalcfgnum { get; set; }

    public long? Maxfeatures { get; set; }

    public long? Flags { get; set; }

    public long? Maxresults { get; set; }

    public DateTime? Cachetime { get; set; }
}
