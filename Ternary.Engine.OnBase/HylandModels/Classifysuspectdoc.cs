using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Classifysuspectdoc
{
    public long Clsuspectdocnum { get; set; }

    public DateTime? Entrydate { get; set; }

    public long? Itemnum { get; set; }

    public long? Originalitemnum { get; set; }

    public long? Originaldocposition { get; set; }

    public long? Batchnum { get; set; }

    public long? Clsystemnum { get; set; }

    public long? Imageoffset { get; set; }

    public long? Suspectreason { get; set; }
}
