using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class M2wdictionary
{
    public long Mwdictnum { get; set; }

    public long? Typenum { get; set; }

    public string? Mwdictname { get; set; }

    public string? Mwdictdescription { get; set; }

    public DateTime? Lastupdate { get; set; }
}
