using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Objectcomment
{
    public long Objectnum { get; set; }

    public long Objecttype { get; set; }

    public string? Objectcomment1 { get; set; }

    public long? Usernum { get; set; }

    public long? Objcommenttype { get; set; }

    public long? Obblobnum { get; set; }

    public long? Flags { get; set; }
}
