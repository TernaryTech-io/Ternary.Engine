using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplandefcomment
{
    public long Epdefcommentnum { get; set; }

    public string? Eptag { get; set; }

    public string? Eptext { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Flags { get; set; }
}
