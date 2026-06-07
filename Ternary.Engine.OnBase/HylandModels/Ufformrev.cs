using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ufformrev
{
    public long Ufformnum { get; set; }

    public long Formrevnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Flags { get; set; }

    public long? Lastmodifieduser { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Ufthemenum { get; set; }

    public long? Revisiontype { get; set; }

    public string? Ufcomment { get; set; }

    public long? Imagedoctype { get; set; }
}
