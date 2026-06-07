using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Changeeventitem
{
    public long? Changeeventnum { get; set; }

    public string? Itemchangedid { get; set; }

    public string? Itemchangedname { get; set; }

    public long? Itemchangedtype { get; set; }

    public long? Changetype { get; set; }

    public string? Changedetail { get; set; }
}
