using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mfannotation
{
    public long Mfannotationnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Xpos1 { get; set; }

    public long? Ypos1 { get; set; }

    public long? Xpos2 { get; set; }

    public long? Ypos2 { get; set; }

    public long? Pagenum { get; set; }

    public string? Notehtml { get; set; }

    public long? Mfannotationtype { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Usernum { get; set; }

    public long? Mfflag { get; set; }
}
