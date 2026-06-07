using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Contentcomposerprocess
{
    public long Ccprocessnum { get; set; }

    public string? Composerpid { get; set; }

    public long? Itemid { get; set; }

    public long? Classid { get; set; }

    public long? Itemcontenttype { get; set; }

    public string? Ccbundleid { get; set; }

    public long? Flags { get; set; }
}
