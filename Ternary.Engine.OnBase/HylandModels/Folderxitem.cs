using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Folderxitem
{
    public long Itemnum { get; set; }

    public long Foldernum { get; set; }

    public long? Seqnum { get; set; }

    public DateTime? Dateadded { get; set; }
}
