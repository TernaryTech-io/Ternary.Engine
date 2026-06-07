using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Portfolioxml
{
    public long Sourcecontenttype { get; set; }

    public long Sourcecontentid { get; set; }

    public string? Datakey { get; set; }

    public string? Xmldata { get; set; }

    public long? Flags { get; set; }

    public long? Srccontclassnum { get; set; }
}
