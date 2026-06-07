using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aiitemtypestat
{
    public long Itemtypenum { get; set; }

    public long? Doccount { get; set; }

    public long? Tagcount { get; set; }

    public long? Aiprobability { get; set; }

    public long? Keytypenum { get; set; }

    public long? Ailayoutnum { get; set; }

    public long? Languagetype { get; set; }

    public string? Learnedtagdata { get; set; }

    public string? Aggregateguid { get; set; }
}
