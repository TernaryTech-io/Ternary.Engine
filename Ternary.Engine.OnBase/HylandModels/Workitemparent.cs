using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workitemparent
{
    public long Wfchildbatchnum { get; set; }

    public long? Contentnum { get; set; }

    public long? Contentclassnum { get; set; }

    public long? Wfcontenttype { get; set; }

    public DateTime? Createddatetime { get; set; }

    public long? Usernum { get; set; }

    public long? Lcnum { get; set; }

    public long? Statenum { get; set; }

    public long? Statenumto { get; set; }

    public long? Actionnum { get; set; }

    public long? Initialchildcount { get; set; }

    public long? Flags { get; set; }
}
