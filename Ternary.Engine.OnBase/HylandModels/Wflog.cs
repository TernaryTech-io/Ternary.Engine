using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wflog
{
    public long Statenum { get; set; }

    public long Lcnum { get; set; }

    public long Itemnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Entrytime { get; set; }

    public DateTime? Exittime { get; set; }

    public long? Flags { get; set; }

    public long? Exitusernum { get; set; }

    public long? Statenumto { get; set; }

    public long? Wfcontenttype { get; set; }

    public long? Contentclassnum { get; set; }
}
