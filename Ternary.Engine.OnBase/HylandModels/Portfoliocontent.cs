using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Portfoliocontent
{
    public long Sourcecontenttype { get; set; }

    public long Sourcecontentid { get; set; }

    public long Wfcontenttype { get; set; }

    public long Contentnum { get; set; }

    public long? Flags { get; set; }

    public long? Srccontclassnum { get; set; }
}
