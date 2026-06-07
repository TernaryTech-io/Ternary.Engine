using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workitemlastowner
{
    public long Statenum { get; set; }

    public long Contentnum { get; set; }

    public long Wfcontenttype { get; set; }

    public long? Ownernum { get; set; }

    public DateTime? Ownedsince { get; set; }

    public long? Flags { get; set; }

    public long? Contentclassnum { get; set; }
}
