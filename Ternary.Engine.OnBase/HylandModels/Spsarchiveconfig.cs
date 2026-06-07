using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Spsarchiveconfig
{
    public long Spsconfignum { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Spsdoclibid { get; set; }

    public string? Spswebid { get; set; }

    public string? Spssiteid { get; set; }

    public long? Flags { get; set; }

    public string? Spscontenttype { get; set; }
}
