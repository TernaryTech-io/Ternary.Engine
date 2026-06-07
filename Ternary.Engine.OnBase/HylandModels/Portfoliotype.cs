using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Portfoliotype
{
    public long Portfoliotypenum { get; set; }

    public string? Portfoliotypename { get; set; }

    public long? Sourcecontenttype { get; set; }

    public long? Flags { get; set; }

    public long? Contentclassnum { get; set; }

    public long? Institution { get; set; }
}
