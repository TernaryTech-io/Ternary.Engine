using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workitemcontainer
{
    public long Contentnum { get; set; }

    public long Wfcontenttype { get; set; }

    public long? Portfolionum { get; set; }

    public long? Flags { get; set; }

    public long? Contentclassnum { get; set; }
}
