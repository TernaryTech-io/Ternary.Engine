using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mftemplate
{
    public long Mftemplatenum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Mfformtypenum { get; set; }

    public long? Mfflag { get; set; }

    public long? Formitemtypenum { get; set; }

    public long? Tiffitemtypenum { get; set; }

    public long? Pdfitemtypenum { get; set; }

    public long? Xmlitemtypenum { get; set; }
}
