using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Foldertyperimhist
{
    public long? Foldertypenum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Datemodified { get; set; }

    public long? Oldretplannum { get; set; }

    public long? Newretplannum { get; set; }

    public long? Flags { get; set; }

    public long? Oldretplansetnum { get; set; }

    public long? Newretplansetnum { get; set; }

    public long? Institution { get; set; }
}
