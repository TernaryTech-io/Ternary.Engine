using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Compounditem
{
    public long Itemnum { get; set; }

    public long Childitemnum { get; set; }

    public long Docrevnum { get; set; }

    public long Childdocrevnum { get; set; }

    public long? Linktype { get; set; }

    public string? Relationpath { get; set; }
}
